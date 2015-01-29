using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Erato.Business;
using Erato.Common;
using Erato.Model;
using Erato.UI.Services;

namespace Erato.UI.Controllers
{
    /// <summary>
    /// 部门控制器
    /// </summary>
    public class DeptController : Controller
    {
        #region Field
        /// <summary>
        /// 部门业务
        /// </summary>
        private DeptBusiness deptBusiness;
        #endregion //Field

        #region Constructor
        public DeptController()
        {
            this.deptBusiness = new DeptBusiness();
        }
        #endregion //Constructor

        #region Action
        /// <summary>
        /// 部门主页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var user = PageService.GetCurrentUser(User.Identity.Name);
            ViewBag.User = user;

            var data = this.deptBusiness.Get();
            return View(data);
        }


        /// <summary>
        /// 部门信息
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ActionResult Details(string id)
        {
            var data = this.deptBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 添加部门
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Create()
        {
            
            return View();
        }

        /// <summary>
        /// 添加部门
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(Dept model)
        {
            if (ModelState.IsValid)
            {
                bool d = this.deptBusiness.DeptNoExists(model.DeptNo);
                if (d == false)
                {
                    bool n = this.deptBusiness.DeptNameExists(model.DeptName);
                    if (!n)
                    {
                        model.Operator = PageService.GetCurrentUser(User.Identity.Name).UserName;
                        model.OperationTime = DateTime.Now;
                        ErrorCode result = this.deptBusiness.Create(model);

                        if (result == ErrorCode.Success)
                        {
                            TempData["Message"] = "添加部门成功";
                            return RedirectToAction("Create");
                        }
                        else
                        {
                            TempData["Message"] = "添加部门失败";
                            ModelState.AddModelError("", "添加部门失败: " + result.DisplayName());
                        }
                    }
                    else
                    {
                        TempData["Message"] = "添加部门失败";
                        ModelState.AddModelError("", "添加部门失败: 部门名称已存在");
                    }
                }
                else
                {
                    TempData["Message"] = "添加部门失败";
                    ModelState.AddModelError("", "添加部门失败: 部门编号已存在");
                }
            }

            return View();
        }

        /// <summary>
        /// 编辑部门
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var data = this.deptBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 编辑部门
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(Dept model)
        {
            if (ModelState.IsValid)
            {
                if (!this.deptBusiness.DeptNameExists(model.DeptName))
                {
                    model.Operator = PageService.GetCurrentUser(User.Identity.Name).UserName;
                    model.OperationTime = DateTime.Now;
                    ErrorCode result = this.deptBusiness.Update(model);

                    if (result == ErrorCode.Success)
                    {
                        TempData["Message"] = "编辑部门成功";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["Message"] = "编辑部门失败";
                        ModelState.AddModelError("", "编辑部门失败: " + result.DisplayName());
                    }
                }
                else
                {
                    TempData["Message"] = "编辑部门失败";
                    ModelState.AddModelError("", "编辑部门失败: 部门名称已存在");
                }
            }

            return View(model);
        }

        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Delete(string id)
        {
            var data = this.deptBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 删除部门
        /// </summary>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm()
        {
            string id = Request.Form["_id"];

            ErrorCode result = this.deptBusiness.Delete(id);
            if (result == ErrorCode.Success)
            {
                TempData["Message"] = "删除部门成功";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Message"] = "删除部门失败";
                return RedirectToAction("Delete", new { id = id });
            }
        }
        #endregion //Action
    }
}