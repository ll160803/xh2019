using Ipedf.Web.BizLogic;
using Ipedf.Web.Control;
using Ipedf.Web.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ipedf.Hrp.Web.common
{
    public partial class UpFile_Display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(base.Request["ID"]))
            {
                base.Response.Write("参数错误");
                base.Response.End();
            }
            else
            {
                string str = base.Request["ID"];
                if (!string.IsNullOrEmpty(str))
                {
                    this.DisplayDetail(str);
                }
            }

        }

        private void DisplayDetail(string fileId)
        {
            EntityObject_COM_FILE t_com_file = new EntityObject_COM_FILE
            {
                ID = fileId
            };
            t_com_file = BizLogicObject_COM_FILE.Proxy.Get(t_com_file);
            if (t_com_file == null)
            {
                base.Response.Write("<span style='font-size:10pt'>要下载的文件未找到！请与系统管理员联系！</span>");
                base.Response.End();
            }
            string path = Path.Combine(ComUpFile.ServerDirectory, t_com_file.SERVER_NAME);
            if (!File.Exists(path))
            {
                base.Response.Write("<span style='font-size:10pt'>要下载的文件未找到！请与系统管理员联系！</span>");
                base.Response.End();
            }
            byte[] buffer = null;
            using (FileStream stream = File.OpenRead(path))
            {
                int count = ((int)stream.Length) - 0x16;
                buffer = new byte[count];
                stream.Position = !(t_com_file.IS_IMPORT == 1M) ? ((long)0x10) : 0L;
                stream.Read(buffer, 0, count);
            }
            base.Response.Clear();
            string str = t_com_file.CLIENT_NAME.ToLower();
            base.Response.AppendHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode(str));
            base.Response.AddHeader("Content-Length", buffer.Length.ToString());
            base.Response.ContentType = t_com_file.CONTENT_TYPE;
            base.Response.BinaryWrite(buffer);
            base.Response.Flush();
            base.Response.End();
        }
    }
}