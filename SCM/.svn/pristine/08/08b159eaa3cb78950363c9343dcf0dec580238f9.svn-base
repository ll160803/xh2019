using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Ipedf.App.SAP_WCF
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“ISAPtoSCM”。
    [ServiceContract]
    public interface ISAPtoSCM
    {
        [OperationContract]
        bool GetPucharseFromSap(List<Sap_PurchasePlan> purcharseList,string Flag);

        [OperationContract]
        bool ChangeStausFromSap(List<Sap_Supply> codeList,string status);

        [OperationContract]
        bool GetMaterFromSap(List<SAP_MATER> materList, string Flag);
        [OperationContract]
        bool ModifyMdmStatusFromSap(List<string> accountCodeList, string status);

        [OperationContract]
        bool GetHrpMaterFromSap(List<HRP_MATER> materList, string Flag);

        [OperationContract]
        string SERVICE(string sapXML, string key);
    }
}
