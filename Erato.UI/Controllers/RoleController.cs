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
    /// 角色控制器
    /// </summary>
    public class RoleController : Controller
    {
        #region Field
        /// <summary>
        /// 角色业务
        /// </summary>
        private RoleBusiness deptBusiness;
        #endregion //Field

        #region Constructor
        public RoleController()
        {
            this.deptBusiness = new RoleBusiness();
        }
        #endregion //Constructor

        #region Action
        /// <summary>
        /// 角色主页
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
        /// 角色信息
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
        /// 添加角色
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Create()
        {
            
            return View();
        }

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(Role model)
        {
            if (ModelState.IsValid)
            {
                bool d = this.deptBusiness.RoleNoExists(model.RoleNo);
                if (d == false)
                {
                    bool n = this.deptBusiness.RoleNameExists(model.RoleName);
                    if (!n)
                    {
                        model.Operator = PageService.GetCurrentUser(User.Identity.Name).UserName;
                        model.OperationTime = DateTime.Now;
                        ErrorCode result = this.deptBusiness.Create(model);

                        if (result == ErrorCode.Success)
                        {
                            TempData["Message"] = "添加角色成功";
                            return RedirectToAction("Create");
                        }
                        else
                        {
                            TempData["Message"] = "添加角色失败";
                            ModelState.AddModelError("", "添加角色失败: " + result.DisplayName());
                        }
                    }
                    else
                    {
                        TempData["Message"] = "添加角色失败";
                        ModelState.AddModelError("", "添加角色失败: 角色名称已存在");
                    }
                }
                else
                {
                    TempData["Message"] = "添加角色失败";
                    ModelState.AddModelError("", "添加角色失败: 角色编号已存在");
                }
            }

            return View();
        }

        /// <summary>
        /// 编辑角色
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
        /// 编辑角色
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(Role model)
        {
            if (ModelState.IsValid)
            {
                if (!this.deptBusiness.RoleNameExists(model.RoleName))
                {
                    model.Operator = PageService.GetCurrentUser(User.Identity.Name).UserName;
                    model.OperationTime = DateTime.Now;
                    ErrorCode result = this.deptBusiness.Update(model);

                    if (result == ErrorCode.Success)
                    {
                        TempData["Message"] = "编辑角色成功";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["Message"] = "编辑角色失败";
                        ModelState.AddModelError("", "编辑角色失败: " + result.DisplayName());
                    }
                }
                else
                {
                    TempData["Message"] = "编辑角色失败";
                    ModelState.AddModelError("", "编辑角色失败: 角色名称已存在");
                }
            }

            return View(model);
        }

        /// <summary>
        /// 删除角色
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
        /// 删除角色
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
                TempData["Message"] = "删除角色成功";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Message"] = "删除角色失败";
                return RedirectToAction("Delete", new { id = id });
            }
        }
        #endregion //Action
    }
}