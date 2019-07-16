using Ipedf.Web.BizLogic;
using Ipedf.Web.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Ipedf.Hrp.Web.common
{
    public partial class UpFile_UpLoad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (base.Request["ACT"] == "DEL")
            {
                this.DeleteFile();
            }
            else
            {
                if (base.Request["uploadId"] != null)
                {
                    this.literID.Text = base.Request["uploadId"].ToString();
                }
                if (!base.IsPostBack && (base.Request.QueryString["uploadId"] == null))
                {
                    this.literID.Text = DateTime.Now.Ticks.ToString();
                    string url = base.Request.Url + (base.Request.Url.Query.Length > 0 ? "&" : "?") + "uploadId=" + this.literID.Text;
                    base.Response.Redirect(url, true);
                }

            }
        }

            private void DeleteFile()
        {
            base.Response.Clear();
            base.Response.CacheControl = "no-cache";
            base.Response.ContentType = "text/xml";
            XmlTextWriter writer = new XmlTextWriter(base.Response.OutputStream, base.Response.ContentEncoding);
            writer.WriteStartDocument();
            writer.WriteStartElement("UpLoad");
            try
            {
                if (!string.IsNullOrEmpty(base.Request["ID"]))
                {
                    CauseObject_COM_FILE cause = new CauseObject_COM_FILE
                    {
                        ID = base.Request["ID"]
                    };
                    BizLogicObject_COM_FILE.Proxy.Delete(cause);
                    writer.WriteElementString("Result", "true");
                }
            }
            catch (Exception exception)
            {
                writer.WriteElementString("Result", "false");
                writer.WriteElementString("Message", exception.Message);
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            base.Response.End();
        }

    }
}