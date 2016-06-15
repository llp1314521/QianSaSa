using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSS.P2P.Model
{
    public class PledgeTender
    {
        public int Pid { get; set; }//抵押标信息
        public int Tid { get; set; }//发标Id
        public int Tstate { get; set; }//抵押类型
        public string Pimg1 { get; set; }//抵押图片
        public string Pimg2 { get; set; }
        public string Pimg3 { get; set; }
        public string Pimg4 { get; set; }
    }
}
