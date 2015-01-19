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
            return View(data);
        }
        #endregion //Action
    }
}