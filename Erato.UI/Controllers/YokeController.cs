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
    /// 磁轭控制器
    /// </summary>
    public class YokeController : Controller
    {
        #region Field
        /// <summary>
        /// 磁轭业务
        /// </summary>
        private YokeBusiness yokeBusiness;
        #endregion //Field

        #region Constructor
        public YokeController()
        {
            this.yokeBusiness = new YokeBusiness();
        }
        #endregion //Constructor

        #region Action
        /// <summary>
        /// 磁轭主页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var data = this.yokeBusiness.Get();
            return View(data);
        }
        #endregion //Action
    }
}