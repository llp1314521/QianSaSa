using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QSS.P2P.Model;
using QSS.P2P.BLL;
using QSS.P2P.COMM;

namespace QSS.P2P.WebUI.Controllers
{
    public class UserInfoController : Controller
    {
        //
        // GET: /UserInfo/

        /// <summary>
        /// 登录页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View();
        }
        /// <summary>
        /// 注册页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Register()
        {
            return View();
        }
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <returns></returns>
        public void AddUser(HttpContext context)
        {
            UserInfoBLL bll = new UserInfoBLL();
            string uName = context.Request["uName"];
            string uPwd = context.Request["uPwd"];
            string uTel = context.Request["uTel"];
            string Validata = context.Request["Validata"];
            context.Response.Write(bll.Login(uName, uPwd, uTel));
        }

    }
}
