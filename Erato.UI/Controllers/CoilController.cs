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
    /// 线圈控制器
    /// </summary>
    public class CoilController : Controller
    {
        #region Field
        /// <summary>
        /// 线圈业务
        /// </summary>
        private CoilBusiness CoilBusiness;
        #endregion //Field

        #region Constructor
        public CoilController()
        {
            this.CoilBusiness = new CoilBusiness();
        }
        #endregion //Constructor

        #region Action
        /// <summary>
        /// 线圈主页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var user = PageService.GetCurrentUser(User.Identity.Name);
            ViewBag.User = user;

            var data = this.CoilBusiness.Get();
            return View(data);
        }


        /// <summary>
        /// 线圈信息
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ActionResult Details(string id)
        {
            var data = this.CoilBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 添加线圈
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// 添加线圈
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(Coil model)
        {
            if (ModelState.IsValid)
            {
                model.Operator= PageService.GetCurrentUser(User.Identity.Name).UserName;
                model.OperationTime = DateTime.Now;
                ErrorCode result = this.CoilBusiness.Create(model);

                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "添加线圈成功";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "添加线圈失败";
                    ModelState.AddModelError("", "添加线圈失败: " + result.DisplayName());
                }
            }

            return View();
        }

        /// <summary>
        /// 编辑线圈
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var data = this.CoilBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 编辑线圈
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(Coil model)
        {
            if (ModelState.IsValid)
            {
                model.Operator = PageService.GetCurrentUser(User.Identity.Name).UserName;
                model.OperationTime = DateTime.Now;
                ErrorCode result = this.CoilBusiness.Update(model);

                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "编辑线圈成功";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "编辑线圈失败";
                    ModelState.AddModelError("", "编辑线圈失败: " + result.DisplayName());
                }
            }

            return View(model);
        }

        /// <summary>
        /// 删除线圈
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Delete(string id)
        {
            var data = this.CoilBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 删除线圈
        /// </summary>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm()
        {
            string id = Request.Form["_id"];

            ErrorCode result = this.CoilBusiness.Delete(id);
            if (result == ErrorCode.Success)
            {
                TempData["Message"] = "删除线圈成功";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Message"] = "删除线圈失败";
                return RedirectToAction("Delete", new { id = id });
            }
        }
        #endregion //Action
    }
}