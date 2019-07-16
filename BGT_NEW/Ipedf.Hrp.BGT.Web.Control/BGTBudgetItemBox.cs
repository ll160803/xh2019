using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Web.UI;
using Ipedf.Web.Control;
[assembly: TagPrefix("Ipedf.Hrp.BGT.Web.Control", "Bgt")]
namespace Ipedf.Hrp.BGT.Web.Control
{
    public class BGTBudgetItemBox : ComBaseBox
    {
        protected override string PrepareListUrl
        {
            get
            {
                return "selectdialog_budgetItem.aspx";
            }
        }
    }
}
