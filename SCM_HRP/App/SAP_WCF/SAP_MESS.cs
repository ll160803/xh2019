using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ipedf.App
{
    public class SAP_MESS
    {
        /// <summary>
        /// 采购订单号
        /// </summary>
        public string EBELN { get; set; }

        /// <summary>
        /// 项目号
        /// </summary>
        public string EBELP { get; set; }

        /// <summary>
        /// 供应商号
        /// </summary>
        public string LIFNR { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 成功无消息，错误会显示错误原因
        /// </summary>
        public string MESS { get; set; }
    }
}