using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QSS.P2P.DAL;
using QSS.P2P.Model;
using System.Data;

namespace QSS.P2P.BLL
{
    public class UserInfoBLL
    {
        UserInfoDAL dal = new UserInfoDAL();
        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="uName">登录名</param>
        /// <param name="uPwd">密码</param>
        /// <returns></returns>
        public int Login(string uName, string uPwd,string uTell)
        {
            return dal.Login(uName, uPwd, uTell);
        }
        /// <summary>
        /// 显示用户信息
        /// </summary>
        /// <param name="Uid">用户编号</param>
        /// <returns>用户信息实体</returns>
        public DataTable ShowUser(int Uid)
        {
            return dal.ShowUser(Uid);
        }
        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="ui">用户实体</param>
        /// <returns>修改结果</returns>
        public int UpUser(UserInfo ui)
        {
            return dal.UpUser(ui);
        }

    }
}
