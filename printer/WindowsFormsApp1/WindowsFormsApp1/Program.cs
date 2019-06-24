using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new print("吴迪\n精神\n职业病人\n后勤部\n10967373\n2019     4     19", 1,"123123"));
            //Application.Run(new print("工作证明\n张XX，男，身份证号：420114XXXXXXXXXXXXX，系我院职工。\n特此证明。\n联系电话：027 - 85726359\n单位地址：湖北省武汉市江汉区解放大道1277号\n华中科技大学同济医学院附属协和医院\n2019年3月29日\n本证明仅用于证明我院员工的工作，不作为我院对该员工任何形式的担保文件。",2));
            Application.Run(new readCode());
            //Application.Run(new print("工作证明\n姓名：张XX，性别：男，身份证号：420114XXXXXXXXXXXXX，系我\n院职工。\n特此证明。\n联系电话：027 - 85726359\n单位地址：湖北省武汉市江汉区解放大道1277号\n华中科技大学同济医学院\n附属协和医院  人事处\n2019年3月29日\n本证明不作为我院对该职工任何形式的担保文件，自开具之日起\n三十天内有效。", 2, "420114XXXXXXXXXXXXX", 3));
        }
    }
}
