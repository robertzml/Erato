﻿using Erato.Business;
using Erato.Common;
using Erato.Model;
using Erato.UI.Models;
using Erato.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Erato.UI.Controllers
{
    /// <summary>
    /// 账户控制器
    /// </summary>
    public class AccountController : Controller
    {
        #region Field
        /// <summary>
        /// 认证服务
        /// </summary>
        private IFormsAuthenticationService formsService;

        /// <summary>
        /// 账户服务
        /// </summary>
        private UserBusiness userBusiness;
        #endregion //Field

        #region Function
        protected override void Initialize(RequestContext requestContext)
        {
            if (formsService == null)
            {
                formsService = new FormsAuthenticationService();
            }
            if (userBusiness == null)
            {
                userBusiness = new UserBusiness();
            }
            base.Initialize(requestContext);
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        #endregion //Function

        #region Action
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }


        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="model"></param>
        /// <param name="returnUrl"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Login(LoginModel model, string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            if (ModelState.IsValid)
            {
                formsService.SignOut();
                HttpContext.Session.Clear();

                ErrorCode result = this.userBusiness.Login(model.UserName, model.Password);
                if (result == ErrorCode.Success)
                {
                    User user = this.userBusiness.GetByUserName(model.UserName);
                    HttpCookie cookie = formsService.SignIn(user.UserName, "admin", false);
                    Response.Cookies.Add(cookie);

                    return RedirectToLocal(returnUrl);
                }
                else
                {
                    ModelState.AddModelError("", result.DisplayName());
                }
            }

            return View(model);
        }

        /// <summary>
        /// 注销
        /// </summary>
        /// <returns></returns>
        public ActionResult Logout()
        {
            formsService.SignOut();
            HttpContext.Session.Clear();

            return RedirectToAction("Login", "Account");
        }
        #endregion //Action
    }
}