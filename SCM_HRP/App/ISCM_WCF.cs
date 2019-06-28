using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Ipedf.App.Models;
using Ipedf.Web.Entity;
using System.IO;

namespace Ipedf.App
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“ISCM_WCF”。
    [ServiceContract]
    public interface ISCM_WCF
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        MessModel LoginSAP(string account, string password);

        [OperationContract]
        WcfMessModel GetSupplyPlanByGYJH(string gyjh);


        [OperationContract]
        MessModel SupplyPlan_MakeSure(string gyjh, string userCode);


        [OperationContract]
        DisplayObject_SCM_D_SUPPLYPLAN[] GetSupplyPlans(int c_page, int c_rows);

        [OperationContract]
        MessModel SupplyPlan_MakeSureBatch(List<string> listCode,string userCode);

        //下载文件  
        [OperationContract]
        string DownLoadFile();
        [OperationContract]
        string DownLoadJsonFile();
    }
    //[MessageContract]
    //public class DownFileResult
    //{
    //    [MessageHeader]
    //    public long FileSize { get; set; }
    //    [MessageHeader]
    //    public bool IsSuccess { get; set; }
    //    [MessageHeader]
    //    public string Message { get; set; }
    //    [MessageBodyMember]
    //    public Stream FileStream { get; set; }
    //}
}
