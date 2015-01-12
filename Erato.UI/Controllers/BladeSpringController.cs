using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Erato.Business;
using Erato.Common;
using Erato.Model;

namespace Erato.UI.Controllers
{
    /// <summary>
    /// 板弹簧控制器
    /// </summary>
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
        // GET: BladeSpring
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Details(int id)
        {
            return View();
        }

        /// <summary>
        /// 添加板弹簧
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Create()
        {
            return View();
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

            return View();
        }        
        #endregion //Action
    }
}