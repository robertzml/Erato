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
    /// 下板弹簧控制器
    /// </summary>
    [EnhancedAuthorize]
    public class LowSpringController : Controller
    {
        #region Field
        /// <summary>
        /// 下板弹簧业务
        /// </summary>
        private LowSpringBusiness LowSpringBusiness;
        #endregion //Field

        #region Constructor
        public LowSpringController()
        {
            this.LowSpringBusiness = new LowSpringBusiness();
        }
        #endregion //Constructor

        #region Action
        /// <summary>
        /// 下板弹簧主页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var user = PageService.GetCurrentUser(User.Identity.Name);
            ViewBag.User = user;

            var data = this.LowSpringBusiness.Get();
            return View(data);
        }


        /// <summary>
        /// 下板弹簧信息
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ActionResult Details(string id)
        {
            var data = this.LowSpringBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 添加下板弹簧
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// 添加下板弹簧
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(LowSpring model)
        {
            if (ModelState.IsValid)
            {
                model.Operator = PageService.GetCurrentUser(User.Identity.Name).UserName;
                model.OperationTime = DateTime.Now;
                ErrorCode result = this.LowSpringBusiness.Create(model);

                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "添加下板弹簧成功";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "添加下板弹簧失败";
                    ModelState.AddModelError("", "添加下板弹簧失败: " + result.DisplayName());
                }
            }

            return View();
        }

        /// <summary>
        /// 编辑下板弹簧
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var data = this.LowSpringBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 编辑下板弹簧
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(LowSpring model)
        {
            if (ModelState.IsValid)
            {
                model.Operator = PageService.GetCurrentUser(User.Identity.Name).UserName;
                model.OperationTime = DateTime.Now;
                ErrorCode result = this.LowSpringBusiness.Update(model);

                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "编辑下板弹簧成功";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "编辑下板弹簧失败";
                    ModelState.AddModelError("", "编辑下板弹簧失败: " + result.DisplayName());
                }
            }

            return View(model);
        }

        /// <summary>
        /// 删除下板弹簧
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Delete(string id)
        {
            var data = this.LowSpringBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 删除下板弹簧
        /// </summary>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm()
        {
            string id = Request.Form["_id"];

            ErrorCode result = this.LowSpringBusiness.Delete(id);
            if (result == ErrorCode.Success)
            {
                TempData["Message"] = "删除下板弹簧成功";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["Message"] = "删除下板弹簧失败";
                return RedirectToAction("Delete", new { id = id });
            }
        }
        #endregion //Action
    }
}