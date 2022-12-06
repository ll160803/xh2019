using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace XH_Print
{
    public class MyFlatButton :Button
    {
        protected override bool ShowFocusCues
        {
            get
            {
                return false;
            }
        }
    }
}
