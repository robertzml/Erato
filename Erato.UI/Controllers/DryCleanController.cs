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
    /// 洗净干燥工序
    /// </summary>
    [EnhancedAuthorize]
    public class DryCleanController : Controller
    {
        #region Action
        // GET: DryClean
        public ActionResult Index()
        {
            return View();
        }
        #endregion //Action
    }
}