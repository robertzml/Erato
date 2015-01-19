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
    /// 电检控制器
    /// </summary>
    [EnhancedAuthorize]
    public class ETestController : Controller
    {
        #region Field
        /// <summary>
        /// 电检业务
        /// </summary>
        private ETestBusiness etestBusiness;
        #endregion //Field

        #region Constructor
        public ETestController()
        {
            this.etestBusiness = new ETestBusiness();
        }
        #endregion //Constructor

        #region Action
        /// <summary>
        /// 电检主页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var data = this.etestBusiness.Get();
            return View(data);
        }

        /// <summary>
        /// 电检信息
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ActionResult Details(string id)
        {
            var data = this.etestBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 添加电检
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// 添加电检
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(ETest model)
        {
            if (ModelState.IsValid)
            {
                ErrorCode result = this.etestBusiness.Create(model);
                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "添加电检成功";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "添加电检失败";
                    ModelState.AddModelError("", "添加电检失败: " + result.DisplayName());
                }
            }

            return View(model);
        }

        /// <summary>
        /// 编辑电检
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var data = this.etestBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 编辑电检
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(ETest model)
        {
            if (ModelState.IsValid)
            {
                ErrorCode result = this.etestBusiness.Update(model);

                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "编辑电检成功";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "编辑电检失败";
                    ModelState.AddModelError("", "编辑电检失败: " + result.DisplayName());
                }
            }

            return View(model);
        }

        /// <summary>
        /// 删除电检
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Delete(string id)
        {
            var data = this.etestBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 删除电检
        /// </summary>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm()
        {
            string id = Request.Form["_id"];

            ErrorCode result = this.etestBusiness.Delete(id);
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