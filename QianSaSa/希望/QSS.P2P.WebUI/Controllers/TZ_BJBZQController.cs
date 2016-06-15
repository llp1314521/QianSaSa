﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QSS.P2P.BLL;
using System.Data;

namespace QSS.P2P.WebUI.Controllers
{
    public class TZ_BJBZQController : Controller
    {
        //
        // GET: /TZ_BJBZQ/
        TenderAndZhaoBiaoBll bll = new TenderAndZhaoBiaoBll();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult XiangXi(int id)
        {
            int Tid = id;
            ViewBag.Tender = bll.Tender(Tid);
            int Uid = Convert.ToInt32(bll.GetUidByTid(Tid));
            ViewBag.UserInfo = bll.UserInfo(Uid);
            ViewBag.ZhaoBiao = bll.ZhaoBiao(Tid);
            return View();
        }

    }
}
