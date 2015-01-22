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
    /// 最终检查控制器
    /// </summary>
    [EnhancedAuthorize]
    public class FinalCheckController : Controller
    {
        #region Field
        /// <summary>
        /// 最终检查业务
        /// </summary>
        private FinalCheckBusiness finalCheckBusiness;
        #endregion //Field

        #region Constructor
        public FinalCheckController()
        {
            this.finalCheckBusiness = new FinalCheckBusiness();
        }
        #endregion //Constructor

        #region Action
        /// <summary>
        /// 最终检查主页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var data = this.finalCheckBusiness.Get();
            ViewBag.Last = this.finalCheckBusiness.GetLast();

            return View(data);
        }

        /// <summary>
        /// 最终检查详细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(string id)
        {
            var data = this.finalCheckBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 添加最终检查
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// 添加最终检查
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(FinalCheck model)
        {
            if (ModelState.IsValid)
            {
                ErrorCode result = this.finalCheckBusiness.Create(model);
                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "添加最终检查成功";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "添加最终检查失败";
                    ModelState.AddModelError("", "添加最终检查失败: " + result.DisplayName());
                }
            }

            return View(model);
        }

        /// <summary>
        /// 编辑最终检查
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var data = this.finalCheckBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 编辑最终检查
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(FinalCheck model)
        {
            if (ModelState.IsValid)
            {
                ErrorCode result = this.finalCheckBusiness.Update(model);

                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "编辑最终检查成功";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "编辑最终检查失败";
                    ModelState.AddModelError("", "编辑最终检查失败: " + result.DisplayName());
                }
            }

            return View(model);
        }

        /// <summary>
        /// 删除最终检查
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Delete(string id)
        {
            var data = this.finalCheckBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 删除最终检查
        /// </summary>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm()
        {
            string id = Request.Form["_id"];

            ErrorCode result = this.finalCheckBusiness.Delete(id);
            if (result == ErrorCode.Success)
            {
                TempData["Message"] = "删除最终检查成功";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Message"] = "删除最终检查失败";
                return RedirectToAction("Delete", new { id = id });
            }
        }
        #endregion //Action
    }
}