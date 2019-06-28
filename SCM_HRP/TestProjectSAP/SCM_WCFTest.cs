using Ipedf.App;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using Ipedf.App.Models;
using System.Collections.Generic;

namespace TestProjectSAP
{


    /// <summary>
    ///这是 SCM_WCFTest 的测试类，旨在
    ///包含所有 SCM_WCFTest 单元测试
    ///</summary>
    [TestClass()]
    public class SCM_WCFTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///GetSupplyPlanByGYJH 的测试
        ///</summary>
        // TODO: 确保 UrlToTest 特性指定一个指向 ASP.NET 页的 URL(例如，
        // http://.../Default.aspx)。这对于在 Web 服务器上执行单元测试是必需的，
        //无论要测试页、Web 服务还是 WCF 服务都是如此。
        [TestMethod()]
        [HostType("ASP.NET")]
        [UrlToTest("http://localhost/App")]
        public void GetSupplyPlanByGYJHTest()
        {
            SCM_XH target = new SCM_XH(); // TODO: 初始化为适当的值
            string gyjh = string.Empty; // TODO: 初始化为适当的值
            WcfMessModel expected = null; // TODO: 初始化为适当的值
            List<WcfPlan_XH> actual;
            List<PlanDetail> list = new List<PlanDetail>();
            list.Add(new PlanDetail
                {
                    BEDAT = Convert.ToDateTime("2016-07-14"),
                    CHARG = "firc160601",
                    CODE = "",
                    EBELN = "4500086093",
                    EEIND = Convert.ToDateTime("2016-07-14"),
                    FLAG = "C",
                    FPBM = "sss",
                    FPHM = "ss",
                    FPJR = 2.67M,
                    GYJH = "00100",
                    GYSACCOUNT = "10000056",
                    GYSNAME = "ww",
                    HSDAT = Convert.ToDateTime("2016-07-14"),
                    MATNR = "ww",
                    WERKST = "www",
                    PKG_AMOUNT = 2M,
                    ORDER_MENGE = 4M,
                    PKG_NUMBER = 2,
                    NETPR = "3.5",
                    MENGE = 20.0000M

                });
            actual = target.ImportSupplyPlan("10000056", "111", "sss", list);
            ;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }
    }
}
