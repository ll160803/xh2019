using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ipedf.Core;
using System.Runtime.Serialization;

namespace Ipedf.Web.Entity
{
   public partial class EntityObject_COMPLETEPERCENT
    {
       /// <summary>
       /// 排名
       /// </summary>
       public int RANK_NUM { get; set; }
       /// <summary>
       /// 供应商账号
       /// </summary>
       public string CODE { get; set; }
       /// <summary>
       /// 供应商名称
       /// </summary>
       public string NAME { get; set; }
       /// <summary>
       /// 百分比
       /// </summary>
       public decimal Percent { get; set; }
       /// <summary>
       /// 采购数量
       /// </summary>
       public decimal MENGE { get; set; }
       /// <summary>
       /// 供货数量
       /// </summary>
       public decimal DONE_Menge { get; set; }
       /// <summary>
       /// 物料号
       /// </summary>
       public string MATNR { get; set; }
       /// <summary>
       /// 物料描述
       /// </summary>
       public string TXZ01 { get; set; }

       public string ID
       {
           get
           {
               return CODE + MATNR;
           }
       }
    }
   [Serializable]
   [DataContract]
   [DataObject("COMPLETEPERCENT")]
   public partial class CauseObject_COMPLETEPERCENT : CauseBase
   {
   }
}
