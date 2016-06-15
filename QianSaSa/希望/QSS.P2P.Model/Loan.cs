using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSS.P2P.Model
{
    public class Loan
    {
        public int Lid { get; set; }//借款id
        public int Uid { get; set; }//借款人id
        public DateTime Ltital { get; set; }//借款标题
        public string Ltime { get; set; }//借款期限
        public decimal Lmoney { get; set; }//借款金额
        public decimal Lfei { get; set; }//借款手续费
        public DateTime Lshijian { get; set; }//借款时间
        public int Lstate { get; set; }//审核
        public DateTime Llasttime { get; set; }//还款时间
    }
}
