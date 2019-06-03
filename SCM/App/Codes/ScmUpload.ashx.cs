﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Models;

using System.IO;
using System.Web.SessionState;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;

namespace Ipedf.App.Codes
{
    /// <summary>
    /// ScmUpload 的摘要说明
    /// </summary>
    public class ScmUpload : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Charset = "utf-8";
            try
            {
                var file = context.Request.Files["FileUpload"];
                string filetype = context.Request["exportexcel"];//附件类型 1工商营业
                //new BaseBLL<WC_Common_FileUploader>().Delete(p => p.RecordGuid == assetGuidStr);//先删除已经有的

                // string fileFolder = "BaseInfo";

                var en_ID = context.Request["En_ID"];

                var relativePath = "SAP";//存放SCM上传的资质
                string uploadPath = HttpContext.Current.Server.MapPath("~/" + relativePath + "/");

                if (file != null)
                {
                    if (!Directory.Exists(uploadPath))
                    {
                        // Directory.CreateDirectory(uploadPath);
                    }
                    Guid IDFILE = Guid.NewGuid();
                    var entity = new EntityObject_COM_FILE();
                    var Suffix = file.FileName.Substring(file.FileName.LastIndexOf('.') + 1);
                    var trueName = file.FileName.Substring(0, file.FileName.LastIndexOf('.'));
                    var fileName = string.Format("{0}.{1}", IDFILE, Suffix);
                    //存储到服务器
                    file.SaveAs(uploadPath + fileName);

                    #region 记录到数据库


                    string returnValue = string.Empty;


                    entity.IS_COMPRESS = decimal.Parse(filetype);
                    entity.FILE_SIZE = file.ContentLength.ToString();
                    entity.CONTENT_TYPE = file.ContentType;
                    // entity.Path = relativePath;
                    entity.SERVER_NAME = fileName;
                    entity.CLIENT_NAME = trueName;
                    if (!string.IsNullOrEmpty(en_ID))
                    {
                        entity.REF_TAB_ID = en_ID;//编辑的时候直接输入
                    }


                    BizLogicObject_COM_FILE.Proxy.Save(entity);

                    context.Response.Write("{\"SERVER_NAME\":\"" + entity.SERVER_NAME.Replace("\\", "@") + "\",\"CLIENT_NAME\":\"" + entity.CLIENT_NAME + "\",\"ID\":\"" + entity.ID + "\"}");//返回文件路径
                    #endregion
                }
                else
                {
                    context.Response.Write("0");
                }

            }
            catch (Exception ex)
            {
                context.Response.Write("0");
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}