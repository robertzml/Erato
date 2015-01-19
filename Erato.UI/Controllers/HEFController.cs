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
    /// HEF洗净控制器
    /// </summary>
    [EnhancedAuthorize]
    public class HEFController : Controller
    {
        #region Field
        /// <summary>
        /// HEF洗净业务
        /// </summary>
        private HEFBusiness hefBusiness;
        #endregion //Field

        #region Constructor
        public HEFController()
        {
            this.hefBusiness = new HEFBusiness();
        }
        #endregion //Constructor

        #region Action
        /// <summary>
        /// HEF洗净工序入口
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var data = this.hefBusiness.Get();
            return View(data);
        }

        /// <summary>
        /// HEF信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(string id)
        {
            var data = this.hefBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 添加HEF洗净
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// 添加HEF洗净
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(HEF model)
        {
            if (ModelState.IsValid)
            {
                ErrorCode result = this.hefBusiness.Create(model);
                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "添加HEF洗净成功";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "添加HEF洗净失败";
                    ModelState.AddModelError("", "添加HEF洗净失败: " + result.DisplayName());
                }
            }

            return View(model);
        }

        /// <summary>
        /// 编辑HEF洗净
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var data = this.hefBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        ///  编辑HEF洗净
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(HEF model)
        {
            if (ModelState.IsValid)
            {
                ErrorCode result = this.hefBusiness.Update(model);

                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "编辑HEF洗净成功";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "编辑HEF洗净失败";
                    ModelState.AddModelError("", "编辑HEF洗净失败: " + result.DisplayName());
                }
            }

            return View(model);
        }

        /// <summary>
        /// 删除HEF洗净
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Delete(string id)
        {
            var data = this.hefBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 删除HEF洗净
        /// </summary>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm()
        {
            string id = Request.Form["_id"];

            ErrorCode result = this.hefBusiness.Delete(id);
            if (result == ErrorCode.Success)
            {
                TempData["Message"] = "删除HEF洗净成功";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Message"] = "删除HEF洗净失败";
                return RedirectToAction("Delete", new { id = id });
            }
        }
        #endregion //Action
    }
}