using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;

namespace Models
{
    public static class SingleFileupload
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="file_Addree">文件存储地址</param>
        /// <param name="file_name">文件名</param>
        /// <param name="file_ID">对应数据库ID</param>
        /// <param name="control_id"></param>
        /// <param name="index">特殊属性</param>
        /// <param name="state">状态，是否审核</param>
        /// <returns></returns>
        public static MvcHtmlString SingleUp(string file_Addree, string file_name, string file_ID, string control_id, string index, int state)
        {
            StringBuilder sb = new StringBuilder();
            var addressID = control_id + "_adr";
            var savebtnId = control_id + "_sbtn";
            var span_delte = control_id + "_spanDele";
            var href_delete = control_id + "_aDele";
            var hidden_id = control_id + "hideId";

            sb.AppendFormat("<input class=\"easyui-validatebox  textbox sTd\" name=\"{1}\" value=\"{0}\" data-options=\"required:true\"></input>",file_Addree,addressID );
            sb.AppendFormat(" <a href=\"#\" class=\"easyui-linkbutton\" name=\"{1}\"  {0} id=\"{1}\" onclick=\"UpLoad({4},'{2}','{3}','{1}')\">上传附件</a>", string.IsNullOrEmpty(file_name) ? "" : "style=\"display: none;\"", savebtnId, span_delte, hidden_id, index) ;
            var deleteStr=string.Format("<a href=\"#\" onclick=\"deleteAttach('{0}','{1}','{2}','{3}')\">删除</a>",file_ID, span_delte,hidden_id,savebtnId);
            sb.AppendFormat("<span id=\"{0}\">{1}{2}</span>", span_delte, file_name, (state == 1 && !string.IsNullOrEmpty(file_name)) ? deleteStr : "");
            sb.AppendFormat("<input id=\"{1}\" type=\"hidden\" name=\"{1}\" value=\"{0}\" />", file_ID,hidden_id);
            return  MvcHtmlString.Create(sb.ToString());
        }
    }
}