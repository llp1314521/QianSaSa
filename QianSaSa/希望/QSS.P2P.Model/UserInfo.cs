using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSS.P2P.Model
{
    public class UserInfo
    {
        public int Uid { get; set; }//用户id
        public string Uname { get; set; } //用户名称
        public string Pwd { get; set; }//密码
        public string PayPwd { get; set; }//支付密码
        public int tell { get; set; }//电话
        public int sex { get; set; }//性别
        public string IDCard { get; set; }//身份证号
        public string RightName { get; set; }//真实姓名
        public string Adress { get; set; }//地址
        public int IsDelete { get; set; }//是否禁用
        public string Uage { get; set; }//年龄
        public int Ifda { get; set; }//身份
    }
}
