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
                    Guid = entity.Ref_Id,
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
                    Zhrzk = entity.ParentOrgId == "5AB270C0-5D33-4203-A54F-4552699FDA3C" ? entity.OrganizeId : entity.ParentOrgId,
                    Zhrzkms = entity.ParentOrgId == "5AB270C0-5D33-4203-A54F-4552699FDA3C" ? entity.F_FullName : entity.ParentOrgName,
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

        public static void SendAttendanceToSap(List<ViewHrmAttandaceSapEntity> entitys)
        {
            try
            {
                System.Net.NetworkCredential c = new System.Net.NetworkCredential(System.Configuration.ConfigurationManager.AppSettings["Sap_User"], System.Configuration.ConfigurationManager.AppSettings["Sap_Password"]);
                SapAttendance.ZHRWS_KQKSHZ gf = new SapAttendance.ZHRWS_KQKSHZ();

                gf.Credentials = c;
                SapAttendance.Zhr00FmKqksspResponse[] ty = new SapAttendance.Zhr00FmKqksspResponse[] { };
                LogFactory.GetLogger("SendAskLeaveToSap").Info("链接SAP开始");
                SapAttendance.Zhr00FmKqkssp input = new SapAttendance.Zhr00FmKqkssp();
                List<SapAttendance.Zhr00T098> list = new List<SapAttendance.Zhr00T098>();
                foreach (var entity in entitys)
                {
                    list.Add(new SapAttendance.Zhr00T098
                    {
                        Guid = entity.Base_Id,
                        Nachn = entity.NACHN,
                        Pernr = entity.PERNR,
                        Zhrbz = entity.Note??"",
                        Zhrks = entity.OrganizeId,
                        Zhrksms = entity.F_FullName,
                        Zhrzk = entity.ParentOrgId == "5AB270C0-5D33-4203-A54F-4552699FDA3C" ? entity.OrganizeId : entity.ParentOrgId,
                        Zhrzkms = entity.ParentOrgId == "5AB270C0-5D33-4203-A54F-4552699FDA3C" ? entity.F_FullName : entity.ParentOrgName,
                        Zper = entity.AttendDate.Replace("-", ""),
                        Zshr = entity.AuditMan??"",
                        Zshrq = entity.AuditDate==null?"": entity.AuditDate.Value.ToString("yyyy-MM-dd"),
                        Ztjr = entity.SubmitMan??"",
                        Ztjrq = entity.SubmitDate.Value.ToString("yyyy-MM-dd"),
                        Ztjsj= entity.SubmitDate.Value.ToString("HH:mm:ss")
                    });
                }
                input.T_098 = list.ToArray();
                gf.Zhr00FmKqkssp(input);
            }
            catch (Exception ex)
            {
                LogFactory.GetLogger("SendAskLeaveToSap").Error("发送SAP失败:" + ex.Message);
            }
        }

        /// <summary>
        /// 保健科传送病假考勤给SAP
        /// </summary>
        /// <param name="entitys"></param>
        /// <param name="AuditDate">提交时间</param>
        /// <param name="AuditMan">提交人</param>
        /// <param name="mainGuid">主表GUID</param>
        public static int BJKAskLeaveToSap(List<ViewAskForLeaveEntity> entitys, string AuditDate, string AuditMan, string mainGuid)
        {
            try
            {
                System.Net.NetworkCredential c = new System.Net.NetworkCredential(System.Configuration.ConfigurationManager.AppSettings["Sap_User"], System.Configuration.ConfigurationManager.AppSettings["Sap_Password"]);
                BJK_AskLeave.ZHRWS_ZGBJKTJ gf = new BJK_AskLeave.ZHRWS_ZGBJKTJ();

                gf.Credentials = c;
                BJK_AskLeave.Zhr00FmZgbjktjResponse back = new BJK_AskLeave.Zhr00FmZgbjktjResponse();
                LogFactory.GetLogger("BJKAskLeaveToSap").Info("链接SAP开始");
                BJK_AskLeave.Zhr00FmZgbjktj input = new BJK_AskLeave.Zhr00FmZgbjktj();

                var listSap = new List<BJK_AskLeave.Zhr00T099>();

                foreach (var entity in entitys)
                {
                    TimeSpan ts = entity.EndDate.Value - entity.StartDate.Value;
                    listSap.Add(new BJK_AskLeave.Zhr00T099
                    {
                        Begda = entity.StartDate.Value.ToString("yyyy-MM-dd"),
                        Endda = entity.EndDate.Value.ToString("yyyy-MM-dd"),

                        Nachn = entity.NACHN,
                        Pernr = entity.PERNR,

                        Zhrbz = entity.F_Description,
                        Zhrjblx = "",
                        Zhrjbzd = entity.SickCheck,
                        Zhrks = entity.OrganizeId,
                        Zhrksms = entity.F_FullName,
                        Zhrqjlx = entity.AskTypeId,
                        Zhrqjms = entity.F_ItemName,
                        Zhrzk = entity.ParentOrgId == "5AB270C0-5D33-4203-A54F-4552699FDA3C" ? entity.OrganizeId : entity.ParentOrgId,
                        Zhrzkms = entity.ParentOrgId == "5AB270C0-5D33-4203-A54F-4552699FDA3C" ? entity.F_FullName : entity.ParentOrgName,
                        Zhrzyks = entity.HosOrganize,
                        Zqjts = ts.Days + 1,
                        Ztjr = entity.SubmitUser,
                        Ztjrq = entity.LeaderAuditTime.Value.ToString("yyyy-MM-dd"),
                        Guiddh = mainGuid,
                        Guidmx = entity.Ref_Id, //这里是专门传值设置的
                        Senro = entity.AskSort.ToString()
                    });
                }
                input.T_099 = listSap.ToArray();
                back = gf.Zhr00FmZgbjktj(input);
                if (back.Mes == "成功")
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                LogFactory.GetLogger("SynUserDataFromSap").Error("发送SAP失败:" + ex.Message);
                return 0;
            }
        }
    }
}