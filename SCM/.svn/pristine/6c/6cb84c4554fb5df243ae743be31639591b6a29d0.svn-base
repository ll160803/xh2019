using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ipedf.Web.Entity;

namespace Ipedf.App.Models
{
    public class WcfMessModel
    {
        public string Mess { get; set; }

        public bool IsSuccess { get; set; }

        public DisplayObject_SCM_D_SUPPLYPLAN SCM_D_SUPPLYPLAN { get; set; }
    }
    /// <summary>
    /// 供应商使用消息
    /// </summary>
    public class WcfMess_XH
    {
        /// <summary>
        /// 返回信息
        /// </summary>
        public string Mess { get; set; }

        /// <summary>
        /// 是否成功调用
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 返回供应商采购计划
        /// </summary>
        public List<Purchase> PurchasePlans { get; set; }
    }

    /// <summary>
    /// 供应商使用消息
    /// </summary>
    public class WcfPlan_XH
    {
        /// <summary>
        /// 唯一标识
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsSuccess { get; set; }
        /// <summary>
        /// 消息
        /// </summary>
        public string MESS { get; set; }

        /// <summary>
        /// 供应计划号
        /// </summary>
        public string CODE { get; set; }
    }
}