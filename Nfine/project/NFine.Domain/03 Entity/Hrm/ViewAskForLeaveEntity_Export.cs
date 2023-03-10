using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain.Entity.Hrm
{
    public partial class ViewAskForLeaveEntity
    {
        /// <summary>
        /// 请假天数
        /// </summary>
        [NotMapped]
        public string days
        {
            get
            {
                if (EndDate.Value.Year == 9999)
                { return ""; }
                else
                {
                    TimeSpan ts = EndDate.Value - StartDate.Value;
                    return (ts.Days + 1) + "天";
                }
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
                if (GBDAT == null) return 0;
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
                    case 5:
                        state = "审核未通过";
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
