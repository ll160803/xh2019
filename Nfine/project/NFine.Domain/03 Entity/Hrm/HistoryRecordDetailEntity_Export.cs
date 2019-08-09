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
                if (EndDate == null) return "";
                TimeSpan ts = EndDate.Value - StartDate.Value;
                return (ts.Days + 1) + "天";
            }
            set
            {
                days = "";
            }
        }
        /// <summary>
        /// 年龄
        /// </summary>
        [NotMapped]
        public int Ages
        {
            get
            {
                return NFine.Code.Common.GetAgeByBirthdate(GBDAT.Value);
            }
            set
            {
                days = "";
            }
        }
        /// <summary>
        /// 状态
        /// </summary>
        [NotMapped]
        public string StateName
        {
            get
            {
                var state = "";
                switch (State.Value)
                {
                    case 1:
                        state = "未提交";
                        break;
                    case 2:
                        state = "已提交";
                        break;
                    case 3:
                        state = "已审核";
                        break;
                    case 4:
                        state = "已发送SAP";
                        break;
                }
                return state;

            }
            set
            {
                days = "";
            }
        }
        /// <summary>
        /// 状态
        /// </summary>
        [NotMapped]
        public string IsNewName
        {
            get
            {
                if (IsNew.Value)
                {
                    return "是";
                }
                else
                {
                    return "否";
                }

            }
            set
            {
                days = "";
            }
        }
    }
}
