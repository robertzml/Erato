﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Erato.UI.Filters;

namespace Erato.UI.Controllers
{
    /// <summary>
    /// 主页
    /// </summary>
    [EnhancedAuthorize]
    public class HomeController : Controller
    {
        #region Action
        /// <summary>
        /// 主页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 菜单
        /// </summary>
        /// <returns></returns>
        [ChildActionOnly]
        public ActionResult Menu()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        #endregion //Action
    }
}