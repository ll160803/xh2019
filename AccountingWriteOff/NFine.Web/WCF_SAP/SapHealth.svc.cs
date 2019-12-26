using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NFine.Web.WCF_SAP
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“SapHealth”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 SapHealth.svc 或 SapHealth.svc.cs，然后开始调试。
    public class SapHealth : ISapHealth
    {
        public String GetHealthyService(string xmlString)
        {
            // 在此处添加操作实现
            HealthyWebRef.OpenWebServiceService openWebService = new HealthyWebRef.OpenWebServiceService();
            return openWebService.healthService(xmlString);

        }
       public String GetName(string xml)
        {
            return "测试" + xml;
        }
    }
}
