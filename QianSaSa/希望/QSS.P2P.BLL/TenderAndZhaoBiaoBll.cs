using QSS.P2P.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSS.P2P.BLL
{
    public class TenderAndZhaoBiaoBll
    {
        TenderAndZhaoBiaoDal dal = new TenderAndZhaoBiaoDal();
        /// <summary>
        /// 根据用户ID获取用户头像，名称，住址
        /// </summary>
        /// <param name="Uid">用户ID</param>
        /// <returns>用户头像，名称，住址的集合</returns>
        public DataTable UserInfo(int Uid)
        {
            return dal.UserInfo(Uid);
        }
        /// <summary>
        /// 根据投资ID获取投资标题，金额，日期，状态，还款日期
        /// </summary>
        /// <param name="Tid">投资ID</param>
        /// <returns>投资标题，金额，日期，状态，还款日期的集合</returns>
        public DataTable Tender(int Tid)
        {
            return dal.Tender(Tid);
        }
        /// <summary>
        /// 根据投资ID获取投标人，投标金额，投标时间
        /// </summary>
        /// <param name="Tid">投资ID</param>
        /// <returns>投标人，投标金额，投标时间的集合</returns>
        public DataTable ZhaoBiao(int Tid)
        {
            return dal.ZhaoBiao(Tid);
        }
        /// <summary>
        /// 根据投资ID获取发布投资信息人员的ID
        /// </summary>
        /// <param name="Tid">投资ID</param>
        /// <returns>发标人</returns>
        public object GetUidByTid(int Tid)
        {
            return dal.GetUidByTid(Tid);
        }


        /// <summary>
        /// 根据贷款的类型进行查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable SelectTdenderByState(int id)
        {
            return dal.SelectTdenderByState(id);

        }
        /// <summary>
        /// 根据还款方式的不同进行查询
        /// </summary>
        /// <param name="Mtime"></param>
        /// <returns></returns>

        public DataTable SelectTenderByMtime(string Mtime)
        {
            return dal.SelectTenderByMtime(Mtime);


        }
        /// <summary>
        /// 显示投资列表
        /// </summary>
        /// <returns></returns>
        public DataTable Tendershowmain()
        {

            return dal.Tendershowmain();
        }
        /// <summary>
        /// 债权转让信息显示
        /// </summary>
        /// <returns></returns>
        public DataTable Zhuaiquanshowmain()
        {
            return dal.Zhuaiquanshowmain();
        }
    }
}
