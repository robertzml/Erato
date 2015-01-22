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
    /// 磁石控制器
    /// </summary>
    public class MagnetController : Controller
    {
        #region Field
        /// <summary>
        /// 磁石业务
        /// </summary>
        private MagnetBusiness MagnetBusiness;
        #endregion //Field

        #region Constructor
        public MagnetController()
        {
            this.MagnetBusiness = new MagnetBusiness();
        }
        #endregion //Constructor

        #region Action
        /// <summary>
        /// 磁石主页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var user = PageService.GetCurrentUser(User.Identity.Name);
            ViewBag.User = user;

            var data = this.MagnetBusiness.Get();
            return View(data);
        }


        /// <summary>
        /// 磁石信息
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ActionResult Details(string id)
        {
            var data = this.MagnetBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 添加磁石
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// 添加磁石
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(Magnet model)
        {
            if (ModelState.IsValid)
            {
                model.Operator= PageService.GetCurrentUser(User.Identity.Name).UserName;
                model.OperationTime = DateTime.Now;
                ErrorCode result = this.MagnetBusiness.Create(model);

                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "添加磁石成功";
                    return RedirectToAction("Create");
                }
                else
                {
                    TempData["Message"] = "添加磁石失败";
                    ModelState.AddModelError("", "添加磁石失败: " + result.DisplayName());
                }
            }

            return View();
        }

        /// <summary>
        /// 编辑磁石
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var data = this.MagnetBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 编辑磁石
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(Magnet model)
        {
            if (ModelState.IsValid)
            {
                model.Operator = PageService.GetCurrentUser(User.Identity.Name).UserName;
                model.OperationTime = DateTime.Now;
                ErrorCode result = this.MagnetBusiness.Update(model);

                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "编辑磁石成功";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "编辑磁石失败";
                    ModelState.AddModelError("", "编辑磁石失败: " + result.DisplayName());
                }
            }

            return View(model);
        }

        /// <summary>
        /// 删除磁石
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Delete(string id)
        {
            var data = this.MagnetBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 删除磁石
        /// </summary>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm()
        {
            string id = Request.Form["_id"];

            ErrorCode result = this.MagnetBusiness.Delete(id);
            if (result == ErrorCode.Success)
            {
                TempData["Message"] = "删除磁石成功";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Message"] = "删除磁石失败";
                return RedirectToAction("Delete", new { id = id });
            }
        }
        #endregion //Action
    }
}