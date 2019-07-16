using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ipedf.Web.BizLogic;

namespace Ipedf.Hrp.Web.common
{
    public class ComControlBar_State
    {
        public static void SettingComControlBar(Ipedf.Web.Control.ComControlBar controlBar,bool is_Edit)
        {
            if (controlBar[Ipedf.Web.Control.ButtonType.Add].Visible)
            {
                controlBar[Ipedf.Web.Control.ButtonType.Add].Visible = is_Edit;
            }
            if (controlBar[Ipedf.Web.Control.ButtonType.AddAfterSave].Visible)
            {
                controlBar[Ipedf.Web.Control.ButtonType.AddAfterSave].Visible = is_Edit;
            }
            if (controlBar[Ipedf.Web.Control.ButtonType.CloseAfterSave].Visible)
            {
                controlBar[Ipedf.Web.Control.ButtonType.CloseAfterSave].Visible = is_Edit;
            }
            if (controlBar[Ipedf.Web.Control.ButtonType.Submit].Visible)
            {
                controlBar[Ipedf.Web.Control.ButtonType.Submit].Visible = is_Edit;
            }
            if (controlBar[Ipedf.Web.Control.ButtonType.UndoSubmit].Visible)
            {
                controlBar[Ipedf.Web.Control.ButtonType.UndoSubmit].Visible = is_Edit;
            }
            if (controlBar[Ipedf.Web.Control.ButtonType.Save].Visible)
            {
                controlBar[Ipedf.Web.Control.ButtonType.Save].Visible = is_Edit;
            }
        }
        public static void SettingComControlBar_Dept(Ipedf.Web.Control.ComControlBar controlBar,int stage)
        {
            SettingComControlBar(controlBar, BizLogicObject_BGT_B_BUDGET_CONTROL_S_DEPT.Proxy.IsEditByButdgeDept(SystemLogic.Proxy.CurrentUser.DEPART_ID, stage));
        }

        public static void SettingComControlBar_Dept(Ipedf.Web.Control.ComControlBar controlBar,string budget_year, int stage)
        {
            SettingComControlBar(controlBar, BizLogicObject_BGT_B_BUDGET_CONTROL_S_DEPT.Proxy.IsEditByButdgeDept(SystemLogic.Proxy.CurrentUser.DEPART_ID,budget_year, stage));
        }
    }
}
