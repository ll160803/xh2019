using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ipedf.Web.Common
{
   public class MDM_DEPT_TYPE
    {
       /// <summary>
       /// 根据供应商类型 设置供应商的角色
       /// </summary>
       /// <param name="DEPT_TYPE_ID"></param>
       /// <returns></returns>
       public static string GetRoleByDeptType(string DEPT_TYPE_ID)
       {
           var roleId = "";
           switch (DEPT_TYPE_ID)
           {
               case "SCM00340001":
                   roleId = "2929640e-bedc-4a3d-a1ee-b628fe30d5ee";
                   break;
               case "SCM00340002":
                   roleId = "scm00340002roleid";
                   break;
           }
           return roleId;
       }
    }
}
