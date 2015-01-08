using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Erato.Model;

namespace Erato.UI.Controllers
{
    public class BladeSpringController : Controller
    {
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

            }

            return View();
        }

        
        #endregion //Action
    }
}