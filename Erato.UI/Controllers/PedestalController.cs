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
    /// 底座控制器
    /// </summary>
    public class PedestalController : Controller
    {
        #region Field
        /// <summary>
        /// 底座业务
        /// </summary>
        private PedestalBusiness PedestalBusiness;
        #endregion //Field

        #region Constructor
        public PedestalController()
        {
            this.PedestalBusiness = new PedestalBusiness();
        }
        #endregion //Constructor

        #region Action
        /// <summary>
        /// 底座主页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var user = PageService.GetCurrentUser(User.Identity.Name);
            ViewBag.User = user;

            var data = this.PedestalBusiness.Get();
            return View(data);
        }


        /// <summary>
        /// 底座信息
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ActionResult Details(string id)
        {
            var data = this.PedestalBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 添加底座
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// 添加底座
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(Pedestal model)
        {
            if (ModelState.IsValid)
            {
                model.Operator= PageService.GetCurrentUser(User.Identity.Name).UserName;
                model.OperationTime = DateTime.Now;
                ErrorCode result = this.PedestalBusiness.Create(model);

                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "添加底座成功";
                    return RedirectToAction("Create");
                }
                else
                {
                    TempData["Message"] = "添加底座失败";
                    ModelState.AddModelError("", "添加底座失败: " + result.DisplayName());
                }
            }

            return View();
        }

        /// <summary>
        /// 编辑底座
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var data = this.PedestalBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 编辑底座
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(Pedestal model)
        {
            if (ModelState.IsValid)
            {
                model.Operator = PageService.GetCurrentUser(User.Identity.Name).UserName;
                model.OperationTime = DateTime.Now;
                ErrorCode result = this.PedestalBusiness.Update(model);

                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "编辑底座成功";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "编辑底座失败";
                    ModelState.AddModelError("", "编辑底座失败: " + result.DisplayName());
                }
            }

            return View(model);
        }

        /// <summary>
        /// 删除底座
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Delete(string id)
        {
            var data = this.PedestalBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 删除底座
        /// </summary>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm()
        {
            string id = Request.Form["_id"];

            ErrorCode result = this.PedestalBusiness.Delete(id);
            if (result == ErrorCode.Success)
            {
                TempData["Message"] = "删除底座成功";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Message"] = "删除底座失败";
                return RedirectToAction("Delete", new { id = id });
            }
        }
        #endregion //Action
    }
}