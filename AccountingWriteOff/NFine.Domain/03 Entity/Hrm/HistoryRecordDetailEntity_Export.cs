using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain.Entity.Hrm
{
    public partial class HistoryRecordDetailEntity
    {
        /// <summary>
        /// 请假天数
        /// </summary>
        [NotMapped]
        public string days
        {
            get
            {
                TimeSpan ts = EndDate.Value - StartDate.Value;
                return (ts.Days + 1) + "天";
            }
            set
            {
                days = "";
            }
        }
    }
}
