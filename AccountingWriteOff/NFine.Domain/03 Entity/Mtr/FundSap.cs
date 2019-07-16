using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain.Entity.Mtr
{
    public class FundSapEntity
    {
        public string FundName { get; set; }
        public string FundCode { get; set; }
        public decimal FundAmound { get; set; }
        public string CardNumber { get; set; }
    }
}
