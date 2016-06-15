using QSS.P2P.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSS.P2P.DAL
{
    public class UserInfoDAL
    {
        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="uName">登录名</param>
        /// <param name="uPwd">密码</param>
        /// <returns></returns>
        public int Login(string uName, string uPwd, string uTell)
        {
            SqlParameter[] parms = new SqlParameter[]{
                new SqlParameter("@uName",uName),
                new SqlParameter("@uPwd",uPwd),
                new SqlParameter("@uTell",uTell)
            };
            string sql = "insert into UserInfo(Uname,Pwd,tell) values('@uName','@uPwd','@uTell')";
            return SqlHelper.ExecteNonQueryText(sql, parms);
        }
        /// <summary>
        /// 显示用户信息
        /// </summary>
        /// <param name="Uid">用户编号</param>
        /// <returns>用户信息实体</returns>
        public DataTable ShowUser(int Uid)
        {
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@Uid",Uid)
            };
            DataTableCollection dc = SqlHelper.GetTableProducts("Li_LoginDeUser", p);
            return dc[0];
        }
        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="ui">用户实体</param>
        /// <returns>修改结果</returns>
        public int UpUser(UserInfo ui)
        {
            SqlParameter[] p = new SqlParameter[]
            {
                new SqlParameter("@Uid",ui.Uid),
                new SqlParameter("@UName",ui.Uname),
                new SqlParameter("@tell",ui.tell),
                new SqlParameter("@Sex",ui.sex),
                new SqlParameter("@IDCard",ui.IDCard),
                new SqlParameter("@RightName",ui.RightName),
                new SqlParameter("@Adress",ui.Adress),
                new SqlParameter("@Uage",ui.Uage),
                new SqlParameter("@Ifda",ui.Ifda)
            };
            return SqlHelper.ExecteNonQueryProducts("Li_UpUser", p);
        }
    }
}
