using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using QSS.P2P.Model;
using QSS.P2P.BLL;
namespace QSS.P2P.WebUI.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        TenderAndZhaoBiaoBll bll = new TenderAndZhaoBiaoBll();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Main()
        {
            return View();
        }
        /// <summary>
        /// 显示所有列表的显示
        /// </summary>
        /// <returns></returns>
        public ActionResult ShowAll()
        {
            DataTable dt = bll.Tendershowmain();
            List<QSS.P2P.Model.Tender> lst = new List<Tender>();
            foreach (DataRow item in dt.Rows)
            {
                Tender td = new Tender();
                td.Tid = Convert.ToInt32( item["Tid"]);
                td.img = item["img"].ToString();
                td.Tid = Convert.ToInt32(item["Tid"]);
                td.Uname = item["Uname"].ToString();
                td.Tbiaoti = item["Tbiaoti"].ToString();
                td.Tmoney = Convert.ToDecimal(item["Tmoney"]);
                td.Tmtime = item["Tmoney"].ToString();
                td.Ttime = Convert.ToDateTime(item["Ttime"]);
                lst.Add(td);
            }
            ViewBag.Tid = lst;
            return View();


        }
        /// <summary>
        /// 显示所有列表的显示
        /// </summary>
        /// <returns></returns>
        public ActionResult ShowAllZhaiquan()
        {
            DataTable dt = bll.Zhuaiquanshowmain();
            List<QSS.P2P.Model.ZhaoBiao> lst = new List<ZhaoBiao>();
            foreach (DataRow item in dt.Rows)
            {
                ZhaoBiao td = new ZhaoBiao();
                td.Tid = Convert.ToInt32(item["Tid"]);
                td.Uname = item["Uname"].ToString();

                td.Zmoney = Convert.ToDecimal(item["Zmoney"]);
                td.Tbiaoti = item["Tbiaoti"].ToString();
                //td.Tmoney = Convert.ToDecimal(item["Tmoney"]);
                td.Tmtime = item["Tmtime"].ToString();
                td.Ttime = item["Ttime"].ToString();
                td.Ztime = item["Ztime"].ToString();
                lst.Add(td);
            }
            ViewBag.Tid = lst;
            return View();


        }
        /// <summary>
        /// 根据贷款类型搜索，信用贷
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult SelectTdenderByState()
        {
            int id = 1;
            DataTable dt = bll.SelectTdenderByState(id);
            List<QSS.P2P.Model.Tender> lst = new List<Tender>();
            foreach (DataRow item in dt.Rows)
            {
                Tender td = new Tender();
                td.img = item["img"].ToString();
                td.Tid = Convert.ToInt32(item["Tid"]);
                td.Uname = item["Uname"].ToString();
                td.Tbiaoti = item["Tbiaoti"].ToString();
                td.Tmoney = Convert.ToDecimal(item["Tmoney"]);
                td.Tmtime = item["Tmoney"].ToString();
                td.Ttime = Convert.ToDateTime(item["Ttime"]);
                lst.Add(td);
            }
            ViewBag.Tid = lst;
            return View("ShowAll");
        
        }
        /// <summary>
        /// 根据贷款类型搜索，抵押贷
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult SelectTdenderByStateD()
        {
            int id = 2;
            DataTable dt = bll.SelectTdenderByState(id);
            List<QSS.P2P.Model.Tender> lst = new List<Tender>();
            foreach (DataRow item in dt.Rows)
            {
                Tender td = new Tender();
                td.img = item["img"].ToString();
                td.Tid = Convert.ToInt32(item["Tid"]);
                td.Uname = item["Uname"].ToString();
                td.Tbiaoti = item["Tbiaoti"].ToString();
                td.Tmoney = Convert.ToDecimal(item["Tmoney"]);
                td.Tmtime = item["Tmoney"].ToString();
                td.Ttime = Convert.ToDateTime(item["Ttime"]);
                lst.Add(td);
            }
            ViewBag.Tid = lst;
            return View("ShowAll");

        }
        /// <summary>
        /// 根据还款日期查询，月还
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult SelectTdenderByMtime()
        {
            string Mtime = "月还";
            DataTable dt = bll.SelectTenderByMtime(Mtime);
            List<QSS.P2P.Model.Tender> lst = new List<Tender>();
            foreach (DataRow item in dt.Rows)
            {
                Tender td = new Tender();
                td.img = item["img"].ToString();

                td.Uname = item["Uname"].ToString();
                td.Tbiaoti = item["Tbiaoti"].ToString();
                td.Tmoney = Convert.ToDecimal(item["Tmoney"]);
                td.Tmtime = item["Tmoney"].ToString();
                td.Ttime = Convert.ToDateTime(item["Ttime"]);
                lst.Add(td);
            }
            ViewBag.Tid = lst;
            return View("ShowAll");

        }
        /// <summary>
        /// 根据还款日期查询，年还
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult SelectTdenderByMtimeY()
        {
            string Mtime = "年还";
            DataTable dt = bll.SelectTenderByMtime(Mtime);
            List<QSS.P2P.Model.Tender> lst = new List<Tender>();
            foreach (DataRow item in dt.Rows)
            {
                Tender td = new Tender();
                td.img = item["img"].ToString();

                td.Uname = item["Uname"].ToString();
                td.Tbiaoti = item["Tbiaoti"].ToString();
                td.Tmoney = Convert.ToDecimal(item["Tmoney"]);
                td.Tmtime = item["Tmoney"].ToString();
                td.Ttime = Convert.ToDateTime(item["Ttime"]);
                lst.Add(td);
            }
            ViewBag.Tid = lst;
            return View("ShowAll");

        }

    }
}
