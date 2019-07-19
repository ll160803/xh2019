using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain.Entity.Mtr
{
    public partial class Fund_B_ConsumeEntity
    {
        [NotMapped]
        public string password { get; set; }
    }
}
