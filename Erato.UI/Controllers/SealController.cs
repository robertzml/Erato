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
    /// 封止工序控制器
    /// </summary>
    [EnhancedAuthorize]
    public class SealController : Controller
    {
        #region Field
        /// <summary>
        /// 封止业务
        /// </summary>
        private SealBusiness sealBusiness;
        #endregion //Field

        #region Constructor
        public SealController()
        {
            this.sealBusiness = new SealBusiness();
        }
        #endregion //Constructor

        #region Action
        /// <summary>
        /// 封止工序入口
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var data = this.sealBusiness.Get();

            ViewBag.Last = this.sealBusiness.GetLast();

            return View(data);
        }

        /// <summary>
        /// 封止信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(string id)
        {
            var data = this.sealBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 添加封止
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Create()
        {
            Seal model = new Seal();           
            model.Cavity = "-";

            return View(model);
        }

        /// <summary>
        /// 添加封止
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(Seal model)
        {
            if (ModelState.IsValid)
            {
                ErrorCode result = this.sealBusiness.Create(model);
                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "添加封止成功";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "添加封止失败";
                    ModelState.AddModelError("", "添加封止失败: " + result.DisplayName());
                }
            }

            return View(model);
        }

        /// <summary>
        /// 编辑封止
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var data = this.sealBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 编辑封止
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(Seal model)
        {
            if (ModelState.IsValid)
            {
                ErrorCode result = this.sealBusiness.Update(model);

                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "编辑封止成功";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "编辑封止失败";
                    ModelState.AddModelError("", "编辑封止失败: " + result.DisplayName());
                }
            }

            return View(model);
        }

        /// <summary>
        /// 删除封止
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Delete(string id)
        {
            var data = this.sealBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 删除封止
        /// </summary>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm()
        {
            string id = Request.Form["_id"];

            ErrorCode result = this.sealBusiness.Delete(id);
            if (result == ErrorCode.Success)
            {
                TempData["Message"] = "删除封止成功";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Message"] = "删除封止失败";
                return RedirectToAction("Delete", new { id = id });
            }
        }
        #endregion //Action
    }
}