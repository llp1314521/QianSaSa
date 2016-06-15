using QSS.P2P.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QSS.P2P.WebUI.Controllers
{
    public class PersonalCenterController : Controller
    {
        //
        // GET: /PersonalCenter/
        UserInfoBLL bll = new UserInfoBLL();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult XinXi()
        {
            int Uid = Convert.ToInt32(Session["UID"]);
            ViewBag.User = bll.ShowUser(Uid);
            return View();
        }
        public ActionResult XiuGai()
        {
            return View();
        }
    }
}
