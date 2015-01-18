using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Erato.Business;
using Erato.Common;
using Erato.Model;
using Erato.UI.Filters;
using Erato.UI.Services;

namespace Erato.UI.Controllers
{
    /// <summary>
    /// 磁轭控制器
    /// </summary>
    public class YokeController : Controller
    {
        #region Field
        /// <summary>
        /// 磁轭业务
        /// </summary>
        private YokeBusiness yokeBusiness;
        #endregion //Field

        #region Constructor
        public YokeController()
        {
            this.yokeBusiness = new YokeBusiness();
        }
        #endregion //Constructor

        #region Action
        /// <summary>
        /// 磁轭主页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var data = this.yokeBusiness.Get();
            return View(data);
        }

        /// <summary>
        /// 磁轭信息
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ActionResult Details(string id)
        {
            var data = this.yokeBusiness.Get(id);
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
        public ActionResult Create(Yoke model)
        {
            if (ModelState.IsValid)
            {
                ErrorCode result = this.yokeBusiness.Create(model);
                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "添加磁轭成功";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "添加磁轭失败";
                    ModelState.AddModelError("", "添加磁轭失败: " + result.DisplayName());
                }
            }

            return View(model);
        }

        /// <summary>
        /// 编辑磁轭
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var data = this.yokeBusiness.Get(id);
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
        public ActionResult Edit(Yoke model)
        {
            if (ModelState.IsValid)
            {
                ErrorCode result = this.yokeBusiness.Update(model);

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
            var data = this.yokeBusiness.Get(id);
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

            ErrorCode result = this.yokeBusiness.Delete(id);
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