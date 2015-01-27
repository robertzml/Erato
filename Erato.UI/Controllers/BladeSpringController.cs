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
using Erato.UI.Models;

namespace Erato.UI.Controllers
{
    /// <summary>
    /// 板弹簧控制器
    /// </summary>
    [EnhancedAuthorize]
    public class BladeSpringController : Controller
    {
        #region Field
        /// <summary>
        /// 板弹簧业务
        /// </summary>
        private BladeSpringBusiness bladeSpringBusiness;
        #endregion //Field

        #region Constructor
        public BladeSpringController()
        {
            this.bladeSpringBusiness = new BladeSpringBusiness();
        }
        #endregion //Constructor

        #region Action
        /// <summary>
        /// 板弹簧主页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var user = PageService.GetCurrentUser(User.Identity.Name);
            ViewBag.User = user;

            var data = this.bladeSpringBusiness.Get();
            ViewBag.Last = this.bladeSpringBusiness.GetLast();

            return View(data);
        }


        /// <summary>
        /// 板弹簧信息
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ActionResult Details(string id)
        {
            var data = this.bladeSpringBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 添加板弹簧
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Create()
        {
            BladeSpring model = new BladeSpring();
            model.LotNo = "a";
            model.Products = "S";
            model.Date = DateTime.Now.ShortDate();
            model.Cavity = "-";

            return View(model);
        }

        /// <summary>
        /// 添加板弹簧
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(BladeSpring model)
        {
            if (ModelState.IsValid)
            {
                model.LotNo = string.Format("{0}-{1}-{2}-{3}-{4}-{5}-{6}", model.Type, model.Custom, model.Products, model.Line, model.Date, model.Shifts, model.SeqNum);

                ErrorCode result = this.bladeSpringBusiness.Create(model);

                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "添加板弹簧成功";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "添加板弹簧失败";
                    ModelState.AddModelError("", "添加板弹簧失败: " + result.DisplayName());
                }
            }

            return View(model);
        }

        /// <summary>
        /// 编辑板弹簧
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var data = this.bladeSpringBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 编辑板弹簧
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(BladeSpring model)
        {
            if (ModelState.IsValid)
            {
                ErrorCode result = this.bladeSpringBusiness.Update(model);

                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "编辑板弹簧成功";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "编辑板弹簧失败";
                    ModelState.AddModelError("", "编辑板弹簧失败: " + result.DisplayName());
                }
            }

            return View(model);
        }

        /// <summary>
        /// 删除板弹簧
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Delete(string id)
        {
            var data = this.bladeSpringBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 删除板弹簧
        /// </summary>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm()
        {
            string id = Request.Form["_id"];

            ErrorCode result = this.bladeSpringBusiness.Delete(id);
            if (result == ErrorCode.Success)
            {
                TempData["Message"] = "删除板弹簧成功";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Message"] = "删除板弹簧失败";
                return RedirectToAction("Delete", new { id = id });
            }
        }

        /// <summary>
        /// 初始化RFID
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult InitRfid()
        {
            return View();
        }
        #endregion //Action
    }
}