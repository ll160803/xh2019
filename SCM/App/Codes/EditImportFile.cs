using System;
using System.Web;
using Ipedf.Web.BizLogic;
using Ipedf.Web.Entity;
using System.IO;

namespace Ipedf.App.Codes
{
    public class EditImportFile : IHttpHandler
    {
        /// <summary>
        /// 您将需要在您网站的 web.config 文件中配置此处理程序，
        /// 并向 IIS 注册此处理程序，然后才能进行使用。有关详细信息，
        /// 请参见下面的链接: http://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpHandler Members

        public bool IsReusable
        {
            // 如果无法为其他请求重用托管处理程序，则返回 false。
            // 如果按请求保留某些状态信息，则通常这将为 false。
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Charset = "utf-8";

            var file = context.Request.Files["FileUpload"];
            string filetype = context.Request["exportexcel"];//附件类型 1工商营业
            //new BaseBLL<WC_Common_FileUploader>().Delete(p => p.RecordGuid == assetGuidStr);//先删除已经有的

            string fileFolder = "BaseInfo";



            var relativePath = "UploadFile\\" + fileFolder + "\\";
            string uploadPath = HttpContext.Current.Server.MapPath("~/UploadFile") + "\\" + fileFolder + "\\";

            if (file != null)
            {
                if (!Directory.Exists(uploadPath))
                {
                    Directory.CreateDirectory(uploadPath);
                }
                Guid IDFILE = Guid.NewGuid();
                var entity = new EntityObject_COM_FILE();
                var Suffix = file.FileName.Substring(file.FileName.IndexOf('.') + 1);
                var trueName = file.FileName.Substring(0, file.FileName.IndexOf('.'));
                var fileName = string.Format("{0}.{1}", IDFILE, Suffix);
                //存储到服务器
                file.SaveAs(uploadPath + fileName);

                #region 记录到数据库


                string returnValue = string.Empty;


                entity.FILE_TYPE = filetype;
                entity.FILE_SIZE = file.ContentLength.ToString();
                entity.CONTENT_TYPE = file.ContentType;
                // entity.Path = relativePath;
                entity.SERVER_NAME = relativePath + fileName;
                entity.CLIENT_NAME = trueName;

                BizLogicObject_COM_FILE.Proxy.Save(entity);

                context.Response.Write("{\"SERVER_NAME\":\"" + entity.SERVER_NAME.Replace("\\", "@") + "\",\"CLIENT_NAME\":\"" + entity.CLIENT_NAME + "\",\"ID\":\"" + entity.ID + "\"}");//返回文件路径
                #endregion
            }
            else
            {
                context.Response.Write("0");
            }
        }

        #endregion
    }
}
