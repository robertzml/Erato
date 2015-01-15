using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Erato.Business;
using Erato.Common;
using Erato.Model;
using Erato.UI.Filters;

namespace Erato.UI.Controllers
{
    /// <summary>
    /// 洗净干燥工序
    /// </summary>
    [EnhancedAuthorize]
    public class DryCleanController : Controller
    {
        #region Field
        /// <summary>
        /// 洗净干燥业务
        /// </summary>
        private DryCleanBusiness dryCleanBusiness;
        #endregion //Field

        #region Constructor
        public DryCleanController()
        {
            this.dryCleanBusiness = new DryCleanBusiness();
        }
        #endregion //Constructor

        #region Action
        /// <summary>
        /// 洗净干燥工序入口
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var data = this.dryCleanBusiness.Get();
            return View(data);
        }

        /// <summary>
        /// 洗净干燥消息
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ActionResult Details(string id)
        {
            var data = this.dryCleanBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 添加洗净干燥
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// 添加洗净干燥
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(DryClean model)
        {
            if (ModelState.IsValid)
            {
                ErrorCode result = this.dryCleanBusiness.Create(model);
                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "添加洗净干燥成功";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "添加洗净干燥失败";
                    ModelState.AddModelError("", "添加洗净干燥失败: " + result.DisplayName());
                }
            }

            return View(model);
        }

        /// <summary>
        /// 编辑洗净干燥
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var data = this.dryCleanBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 编辑洗净干燥
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(DryClean model)
        {
            if (ModelState.IsValid)
            {
                ErrorCode result = this.dryCleanBusiness.Update(model);

                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "编辑洗净干燥成功";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "编辑洗净干燥失败";
                    ModelState.AddModelError("", "编辑洗净干燥失败: " + result.DisplayName());
                }
            }

            return View(model);
        }

        /// <summary>
        /// 删除洗净干燥
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Delete(string id)
        {
            var data = this.dryCleanBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 删除洗净干燥
        /// </summary>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm()
        {
            string id = Request.Form["_id"];

            ErrorCode result = this.dryCleanBusiness.Delete(id);
            if (result == ErrorCode.Success)
            {
                TempData["Message"] = "删除洗净干燥成功";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Message"] = "删除洗净干燥失败";
                return RedirectToAction("Delete", new { id = id });
            }
        }
        #endregion //Action
    }
}