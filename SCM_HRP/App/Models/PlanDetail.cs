using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ipedf.App.Models
{
    public class PlanDetail
    {
        /// <summary>
        /// 采购凭证号
        /// </summary>
        public string EBELN { get; set; }
        /// <summary>
        /// 采购凭证项目编号
        /// </summary>
        public string GYJH { get; set; }
        /// <summary>
        /// 供应商账户
        /// </summary>
        public string GYSACCOUNT { get; set; }
        /// <summary>
        /// 供应商表述
        /// </summary>
        public string GYSNAME { get; set; }
        /// <summary>
        /// 物料号
        /// </summary>
        public string MATNR { get; set; }
        /// <summary>
        /// 物料描述
        /// </summary>
        public string TXZ01 { get; set; }
        /// <summary>
        /// 院区
        /// </summary>
        public string WERKS { get; set; }
        /// <summary>
        /// 库存地点
        /// </summary>
        public string LGORT { get; set; }

        /// <summary>
        /// 计划数量
        /// </summary>
        public decimal MENGE { get; set; }

        /// <summary>
        /// 计量单位
        /// </summary>
        public string MEINS { get; set; }
        /// <summary>
        /// 竞价
        /// </summary>
        public string NETPR { get; set; }

        /// <summary>
        /// 批次
        /// </summary>
        public string CHARG { get; set; }

        /// <summary>
        /// 生产日期
        /// </summary>
        public DateTime HSDAT { get; set; }

        /// <summary>
        /// 计量单位描述
        /// </summary>
        public string MSEHT { get; set; }

        /// <summary>
        /// 工厂描述
        /// </summary>
        public string WERKST { get; set; }

        /// <summary>
        /// 供应计划号
        /// </summary>
        public string CODE { get; set; }
        /// <summary>
        /// 有效日期
        /// </summary>
        public DateTime VFDAT { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        public string FPHM { get; set; }

        /// <summary>
        /// 发票金额
        /// </summary>
        public decimal FPJR { get; set; }
        /// <summary>
        /// 发票日期
        /// </summary>
        public DateTime FPRQ { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string COMMENTS { get; set; }
        /// <summary>
        /// 发票编码
        /// </summary>
        public string FPBM { get; set; }


        /// <summary>
        ///  交货日期       
        /// </summary>
        public DateTime EEIND { get; set; }

        /// <summary>
        /// 凭证日期
        /// </summary>
        public DateTime BEDAT { get; set; }

        /// <summary>
        /// 包装数量
        /// </summary>
        public decimal PKG_AMOUNT { get; set; }

        /// <summary>
        /// 箱数
        /// </summary>
        public decimal PKG_NUMBER { get; set; }

        /// <summary>
        /// 采购订单数量
        /// </summary>
        public decimal ORDER_MENGE { get; set; }
        /// <summary>
        /// 标志 
        /// </summary>
        public string FLAG { get; set; }

        public string ID { get; set; }
    }
}