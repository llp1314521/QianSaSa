﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSS.P2P.DAL
{
    public class TenderAndZhaoBiaoDal
    {
        /// <summary>
        /// 根据用户ID获取用户头像，名称，住址
        /// </summary>
        /// <param name="Uid">用户ID</param>
        /// <returns>用户头像，名称，住址的集合</returns>
        public DataTable UserInfo(int Uid)
        {
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@Uid",Uid)
            };
            DataTableCollection dc = SqlHelper.GetTableProducts("Li_User", p);
            return dc[0];
        }
        /// <summary>
        /// 根据投资ID获取投资标题，金额，日期，状态，还款日期
        /// </summary>
        /// <param name="Tid">投资ID</param>
        /// <returns>投资标题，金额，日期，状态，还款日期的集合</returns>
        public DataTable Tender(int Tid)
        {
            //SqlParameter s = new SqlParameter("@Tid",Tid);
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@Tid",Tid)
            };
            DataTableCollection dc = SqlHelper.GetTableProducts("Li_TenderList", p);
            return dc[0];
        }
        /// <summary>
        /// 根据投资ID获取投标人，投标金额，投标时间
        /// </summary>
        /// <param name="Tid">投资ID</param>
        /// <returns>投标人，投标金额，投标时间的集合</returns>
        public DataTable ZhaoBiao(int Tid)
        {
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@Tid",Tid)
            };
            DataTableCollection dc = SqlHelper.GetTableProducts("Li_ZhaoBiaoList", p);
            return dc[0];
        }
        /// <summary>
        /// 根据投资ID获取发布投资信息人员的ID
        /// </summary>
        /// <param name="Tid">投资ID</param>
        /// <returns>发标人</returns>
        public object GetUidByTid(int Tid)
        {
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@Tid",Tid)
            };
            return SqlHelper.ExecuteScalarProducts("Li_GetUidByTid", p);
        }
        /// <summary>
        /// 根据贷款的类型进行查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable SelectTdenderByState(int id)
        {

            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@Tstate",id)
            };
            DataTableCollection dc = SqlHelper.GetTableProducts("pro_SelectTdenderByState1", p);
            return dc[0];
        
        }
        /// <summary>
        /// 根据还款方式的不同进行查询
        /// </summary>
        /// <param name="Mtime"></param>
        /// <returns></returns>

        public DataTable SelectTenderByMtime(string Mtime)
        {
            SqlParameter[] p = new SqlParameter[] { 
            
                new SqlParameter("@Tmtime",Mtime)
            };
            DataTableCollection dc = SqlHelper.GetTableProducts("proc_SelectTenderByMtime1", p);
            return dc[0];
        
        
        }

        /// <summary>
        /// 投资信息显示
        /// </summary>
        /// <returns></returns>
        public DataTable Tendershowmain()
        {
            DataTableCollection dc = SqlHelper.GetTableProducts("pro_qyyTenderShowMain", null);
            return dc[0];
        }

        /// <summary>
        /// 债权转让信息显示
        /// </summary>
        /// <returns></returns>
        public DataTable Zhuaiquanshowmain()
        {
            DataTableCollection dc = SqlHelper.GetTableProducts("proc_qyyZhaiquanShowmain", null);
            return dc[0];
        }
    }
}
