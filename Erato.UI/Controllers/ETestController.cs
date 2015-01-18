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
        #endregion //Action
    }
}