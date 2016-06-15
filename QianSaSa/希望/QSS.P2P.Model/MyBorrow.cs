using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSS.P2P.Model
{
    public class MyBorrow
    {

        public int Mid { get; set; }//投资资产ID
        public decimal MBmoney { get; set; }//累计借款总额
        public decimal MDmonry { get; set; }//代还本金
        public decimal MInterest { get; set; }//代还利息
        public int Uid { get; set; }//外键用户


    }
}
