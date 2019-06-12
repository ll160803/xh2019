using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text;

namespace SapUserData
{
    public class SAPHandle
    {
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.AppSettings["conn"]);

        MySqlDataAdapter da = new MySqlDataAdapter();

        MySqlCommand cmd;
        public static SapHrm.Zhr00SKqryxx[] SynUserDataFromSap()
        {
            System.Net.NetworkCredential c = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["Sap_User"], ConfigurationManager.AppSettings["Sap_Password"]);
            SapHrm.ZWS_KQRYXX gf = new SapHrm.ZWS_KQRYXX();

            gf.Credentials = c;
            SapHrm.Zhr00SKqryxx[] ty = new SapHrm.Zhr00SKqryxx[] { };
            LogFactory.GetLogger("SynUserDataFromSap").Info("链接SAP开始");
            var ry = gf.Zhr00FmKqryxx(new SapHrm.Zhr00FmKqryxx { TRyxx = ty });
            LogFactory.GetLogger("SynUserDataFromSap").Info("获取SAP数据，数量为：" + ry.TRyxx.Length);
            return ry.TRyxx;
        }
        public void GetMysqlUserData(SapHrm.Zhr00SKqryxx[] res)
        {
            cmd = new MySqlCommand("select * from hrm_user", conn);

            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            //da.Fill(ds, "Table");
            LogFactory.GetLogger("GetMysqlUserData").Info("从mysql获取数据");
            // 创建命令构建器，会自动创建更新命令，不必手动提供或创建。
            MySqlCommandBuilder myCommandBuilder = new MySqlCommandBuilder(da);

            // 为 MissingSchemaAction 属性设置 AddWithKey，除非指定 AddWithKey，Fill 将不会检索到主键 & 唯一键信息。
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "Table");
            var data = ds.Tables["Table"];
            var data_N = data.Clone();
            foreach (var user in res)
            {
                var row = data_N.Select("PERNR='" + user.Pernr + "'").FirstOrDefault();
                if (row != null)
                {
                    row["ZHRBTTXT"] = user.Zhrbttxt;
                    row["ZHRBTRTL"] = user.Zhrbtrtl;
                    row["YGGH"] = user.Yggh;
                    row["RYLB"] = user.Rylb;
                    row["PTEXT"] = user.Ptext;
                    row["PKEXT"] = user.Pkext;
                    row["PERSK"] = user.Persk;
                    row["PERSG"] = user.Persg;
                    row["NAME1"] = user.Name1;
                    row["NACHN"] = user.Nachn;
                    row["GESCTXT"] = user.Gesctxt;
                    row["GESCH"] = user.Gesch;
                    row["GBDAT"] = user.Gbdat;
                    row["BTRTL"] = user.Btrtl;
                    row["BTEXT"] = user.Btext;
                }
                else
                {
                    var nr = data.NewRow();
                    nr["ZHRBTTXT"] = user.Zhrbttxt;
                    nr["ZHRBTRTL"] = user.Zhrbtrtl;
                    nr["YGGH"] = user.Yggh;
                    nr["RYLB"] = user.Rylb;
                    nr["PTEXT"] = user.Ptext;
                    nr["PKEXT"] = user.Pkext;
                    nr["PERSK"] = user.Persk;
                    nr["PERSG"] = user.Persg;
                    nr["NAME1"] = user.Name1;
                    nr["NACHN"] = user.Nachn;
                    nr["GESCTXT"] = user.Gesctxt;
                    nr["GESCH"] = user.Gesch;
                    nr["GBDAT"] = user.Gbdat;
                    nr["BTRTL"] = user.Btrtl;
                    nr["BTEXT"] = user.Btext;
                    nr["PERNR"] = user.Pernr;
                    nr["F_ID"] = Guid.NewGuid().ToString();
                    data.Rows.Add(nr);
                }
            }
            da.Update(ds, "Table");
            ds.AcceptChanges();
            LogFactory.GetLogger("GetMysqlUserData").Info("更新或插入数据完成");
        }

        public void InsertMysql(SapHrm.Zhr00SKqryxx[] res, DataTable data)
        {
            foreach (var user in res)
            {
                if (data.Select("PERNR='" + user.Pernr + "'").Length > 0)
                {
                    StringBuilder strSql = new StringBuilder();
                    strSql.AppendFormat("update hrm_user set ZHRBTTXT='{0}' ", user.Zhrbttxt);
                    strSql.AppendFormat(",ZHRBTRTL='{0}'", user.Zhrbtrtl);
                    strSql.AppendFormat(",YGGH='{0}'", user.Yggh);
                    strSql.AppendFormat(",RYLB='{0}'", user.Rylb);
                    strSql.AppendFormat(",PTEXT='{0}'", user.Ptext);
                    strSql.AppendFormat(",PKEXT='{0}'", user.Pkext);
                    strSql.AppendFormat(",PERSK='{0}'", user.Persk);
                    strSql.AppendFormat(",PERSG='{0}'", user.Persg);
                    //  strSql.AppendFormat(",PERNR='{0}'", user.Pernr);
                    // strSql.AppendFormat(",NickName='{0}'", user.ni);
                    strSql.AppendFormat(",NAME1='{0}'", user.Name1);
                    strSql.AppendFormat(",NACHN='{0}'", user.Nachn);
                    strSql.AppendFormat(",GESCTXT='{0}'", user.Gesctxt);
                    strSql.AppendFormat(",GESCH='{0}'", user.Gesch);
                    strSql.AppendFormat(",GBDAT='{0}'", user.Gbdat);
                    strSql.AppendFormat(",BTRTL='{0}'", user.Btrtl);
                    strSql.AppendFormat(",BTEXT='{0}' ", user.Btext);
                    strSql.AppendFormat("where PERNR='{0}' ", user.Pernr);
                }
            }
        }
    }
}