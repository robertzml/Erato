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
    /// ACT组立控制器
    /// </summary>
    [EnhancedAuthorize]
    public class ACTController : Controller
    {
        #region Field
        /// <summary>
        /// ACT组立业务对象
        /// </summary>
        private ACTBusiness actBusiness;
        #endregion //Field

        #region Constructor
        public ACTController()
        {
            this.actBusiness = new ACTBusiness();
        }
        #endregion //Constructor

        #region Action
        /// <summary>
        /// ACT组立主页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var data = this.actBusiness.Get();

            ViewBag.Last = this.actBusiness.GetLast();

            return View(data);
        }

        /// <summary>
        /// ACT详细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(string id)
        {
            var data = this.actBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 添加ACT
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Create()
        {
            ACT model = new ACT();
            model.LotNo = "0";
            model.Products = "A";
            model.Date = DateTime.Now.ShortDate();
            model.Cavity = "-";

            return View(model);
        }

        /// <summary>
        /// 添加ACT
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(ACT model)
        {
            if (ModelState.IsValid)
            {
                model.LotNo = string.Format("{0}-{1}-{2}-{3}-{4}-{5}-{6}", model.Type, model.Custom, model.Products, model.Line, model.Date, model.Shifts, model.SeqNum);

                ErrorCode result = this.actBusiness.Create(model);
                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "添加ACT成功";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "添加ACT失败";
                    ModelState.AddModelError("", "添加ACT失败: " + result.DisplayName());
                }
            }

            return View(model);
        }

        /// <summary>
        /// 编辑ACT
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var data = this.actBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 编辑ACT
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(ACT model)
        {
            if (ModelState.IsValid)
            {
                ErrorCode result = this.actBusiness.Update(model);

                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "编辑ACT成功";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "编辑ACT失败";
                    ModelState.AddModelError("", "编辑ACT失败: " + result.DisplayName());
                }
            }

            return View(model);
        }

        /// <summary>
        /// 删除ACT
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Delete(string id)
        {
            var data = this.actBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 删除ACT
        /// </summary>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm()
        {
            string id = Request.Form["_id"];

            ErrorCode result = this.actBusiness.Delete(id);
            if (result == ErrorCode.Success)
            {
                TempData["Message"] = "删除ACT成功";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Message"] = "删除ACT失败";
                return RedirectToAction("Delete", new { id = id });
            }
        }
        #endregion //Action
    }
}