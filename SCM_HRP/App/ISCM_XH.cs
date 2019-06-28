using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Ipedf.App.Models;

namespace Ipedf.App
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“ISCM_XH”。
    [ServiceContract]
    public interface ISCM_XH
    {
        [OperationContract]
        void DoWork();

        /// <summary>
        /// 导出采购订单
        /// </summary>
        /// <param name="userName">供应商账号</param>
        /// <param name="password">登录SCM密码</param>
        /// <param name="startTime">采购订单开始时间</param>
        /// <param name="endTime">采购订单结束时间</param>
        /// <returns></returns>
        [OperationContract]
        WcfMess_XH ExportPurchasePlan(string userName, string password, DateTime startTime, DateTime endTime);

        [OperationContract]
        List<WcfPlan_XH> ImportSupplyPlan(string userName, string password,string trueName, List<PlanDetail> PlanDetails);
    }
}
