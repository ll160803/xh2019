using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain.Entity.Hrm
{
    public enum AskLeaveStateType
    {
        未提交 = 1,
        已提交 = 2,
        审核未通过 = 0,
        已审核 = 3,
        已推送SAP = 4
    }
    public enum UserType
    {
        医生 = 1,
        护士 = 2
    }
    public enum AskLeaveType
    {
        病产假 = 1,
        非病产假 = 0
    }
    public class AttendanceNote
    {
        public string Id { get; set; }
        public string Note { get; set; }
    }
}
