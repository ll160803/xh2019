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
       public string Per {
           get
           {
               if (Percent == null)
               {
                   return "0%";
               }
               return Percent.ToString() + "%";
           }
       }
    }
   
}
