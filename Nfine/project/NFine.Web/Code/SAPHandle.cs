using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text;
using NFine.Code;
using NFine.Domain.Entity.Hrm;

namespace NFine.Web.Code
{
    public class SAPHandle
    {

        public static void SendAskLeaveToSap(ViewAskForLeaveEntity entity)
        {
            try
            {
                System.Net.NetworkCredential c = new System.Net.NetworkCredential(System.Configuration.ConfigurationManager.AppSettings["Sap_User"], System.Configuration.ConfigurationManager.AppSettings["Sap_Password"]);
                HrmSap.ZHRWS_KQJLMX gf = new HrmSap.ZHRWS_KQJLMX();

                gf.Credentials = c;
                HrmSap.Zhr00FmKqjlmxResponse[] ty = new HrmSap.Zhr00FmKqjlmxResponse[] { };
                LogFactory.GetLogger("SynUserDataFromSap").Info("链接SAP开始");
                TimeSpan ts = entity.EndDate.Value - entity.StartDate.Value;

                var ry = gf.Zhr00FmKqjlmx(new HrmSap.Zhr00FmKqjlmx
                {
                    Begda = entity.StartDate.Value.ToString("yyyy-MM-dd"),
                    Endda = entity.EndDate.Value.ToString("yyyy-MM-dd"),
                    Guid = entity.F_Id,
                    Nachn = entity.NACHN,
                    Pernr = entity.PERNR,
                    Senro = entity.AskSort.ToString().PadLeft(4, '0'),
                    Zhrbz = entity.F_Description,
                    Zhrjblx = "",
                    Zhrjbzd = entity.SickCheck,
                    Zhrks = entity.OrganizeId,
                    Zhrksms = entity.F_FullName,
                    Zhrqjlx = entity.AskTypeId,
                    Zhrqjms = entity.F_ItemName,
                    Zhrzk = entity.ParentOrgId,
                    Zhrzkms = entity.ParentOrgName,
                    Zhrzyks = entity.HosOrganize,
                    Zqjts = ts.Days + 1,
                    Ztjr = entity.SubmitUser,
                    Ztjrq = entity.LeaderAuditTime.Value.ToString("yyyy-MM-dd")

                });

            }
            catch (Exception ex)
            {
                LogFactory.GetLogger("SynUserDataFromSap").Error("发送SAP失败:" + ex.Message);
            }
        }


    }
}