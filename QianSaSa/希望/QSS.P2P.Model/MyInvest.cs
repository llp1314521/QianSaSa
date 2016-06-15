using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSS.P2P.Model
{
    public class MyInvest
    {
        public int Mid { get; set; }//投资资产ID
        public decimal MAmoney { get; set; }//累计投资总额
        public decimal MDmonry { get; set; }//代收本金
        public decimal MInterest { get; set; }//代收利息
        public int Uid { get; set; }//用户id


    }
}
