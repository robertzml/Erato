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
    /// 磁轭控制器
    /// </summary>
    public class YokesController : Controller
    {
        #region Field
        /// <summary>
        /// 磁轭业务
        /// </summary>
        private YokesBusiness YokesBusiness;
        #endregion //Field

        #region Constructor
        public YokesController()
        {
            this.YokesBusiness = new YokesBusiness();
        }
        #endregion //Constructor

        #region Action
        /// <summary>
        /// 磁轭主页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var user = PageService.GetCurrentUser(User.Identity.Name);
            ViewBag.User = user;

            var data = this.YokesBusiness.Get();
            return View(data);
        }


        /// <summary>
        /// 磁轭信息
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ActionResult Details(string id)
        {
            var data = this.YokesBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 添加磁轭
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// 添加磁轭
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(Yokes model)
        {
            if (ModelState.IsValid)
            {
                model.Operator= PageService.GetCurrentUser(User.Identity.Name).UserName;
                model.OperationTime = DateTime.Now;
                ErrorCode result = this.YokesBusiness.Create(model);

                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "添加磁轭成功";
                    return RedirectToAction("Create");
                }
                else
                {
                    TempData["Message"] = "添加磁轭失败";
                    ModelState.AddModelError("", "添加磁轭失败: " + result.DisplayName());
                }
            }

            return View();
        }

        /// <summary>
        /// 编辑磁轭
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var data = this.YokesBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 编辑磁轭
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(Yokes model)
        {
            if (ModelState.IsValid)
            {
                model.Operator = PageService.GetCurrentUser(User.Identity.Name).UserName;
                model.OperationTime = DateTime.Now;
                ErrorCode result = this.YokesBusiness.Update(model);

                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "编辑磁轭成功";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "编辑磁轭失败";
                    ModelState.AddModelError("", "编辑磁轭失败: " + result.DisplayName());
                }
            }

            return View(model);
        }

        /// <summary>
        /// 删除磁轭
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Delete(string id)
        {
            var data = this.YokesBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 删除磁轭
        /// </summary>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm()
        {
            string id = Request.Form["_id"];

            ErrorCode result = this.YokesBusiness.Delete(id);
            if (result == ErrorCode.Success)
            {
                TempData["Message"] = "删除磁轭成功";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Message"] = "删除磁轭失败";
                return RedirectToAction("Delete", new { id = id });
            }
        }
        #endregion //Action
    }
}