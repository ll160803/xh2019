using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ipedf.Web.Common;
using Ipedf.Web.BizLogic;
using Ipedf.Web.Entity;
using System.Text;
using NPOI.SS.UserModel;
using System.Web.SessionState;

namespace Ipedf.App.Codes
{
    /// <summary>
    /// UploadSupplyPlan 的摘要说明
    /// </summary>
    public class UploadSupplyPlan : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Charset = "utf-8";

            HttpPostedFile file = context.Request.Files["fileExcel"];
            var msg = NPOIReadExcel.ReadExcelAndCheck(BatchInsertSupply, file, HttpContext.Current.Server.MapPath("~/UploadFile/ImportDocument/"));
            context.Response.Write(msg);
        }
        public string BatchInsertSupply(ISheet sheet, IWorkbook workbook, int startRow)
        {
            StringBuilder sbMsg = new StringBuilder();
            int rowCount = sheet.LastRowNum;
            var list_supp_C = new List<EntityObject_SCM_D_SUPPLYPLAN>();
            if (rowCount > 51)
            {
                sbMsg.Append("每次上传的最大数量为50");
                return sbMsg.ToString();
            }
            var IsLimit = SupplierLimit.IsSettingLimit(SystemLogic.Proxy.CurrentUser.ACCOUNT) ? 0 : 1;//是否验收合格证书上传 0是不限制 1限制
            for (int i = startRow; i <= rowCount; ++i)
            {
                StringBuilder rowMsg = new StringBuilder();
                var ebelp = "";
                var ebeln = "";
                var gysAccount = "";
                var menge = 0M;
                var charge = "";
                DateTime HSDAT = new DateTime();
                DateTime VFDAT = new DateTime(); ;
                DateTime FPRQ = new DateTime(); ;
                var pkgNumber = 0M;
                int pkg_AMOUNT = 0;
                var fptm = "";
                var fpjr = 0M;
                var fphm = "";
                var comments = "";

                IRow row = sheet.GetRow(i);
                if (row != null)
                {
                    #region 基本数据格式验证
                    int y = -1;
                    //var cell0 = row.GetCell(y);
                    //if (cell0 == null)
                    //{
                    //    rowMsg.Append("供应商账号为空;");
                    //}
                    //else
                    //{
                    //    gysAccount = cell0.ToString().Trim();
                    //    if (gysAccount == "")
                    //    {
                    //        rowMsg.Append("供应商账号为空;");
                    //    }
                    //}
                    var cell1 = row.GetCell(y + 1);
                    if (cell1 == null)
                    {
                        rowMsg.Append("采购订单编号为空;");
                    }
                    else
                    {
                        ebeln = cell1.ToString().Trim();
                        if (ebeln == "")
                        {
                            rowMsg.Append("采购订单编号为空;");
                        }
                    }
                    var cell2 = row.GetCell(y + 2);
                    if (cell2 == null)
                    {
                        rowMsg.Append("项目编号为空;");
                    }
                    else
                    {
                        ebelp = cell2.ToString().Trim();
                        if (ebelp == "")
                        {
                            rowMsg.Append("项目编号为空;");
                        }
                    }
                    var cell3 = row.GetCell(y + 3);
                    if (cell3 == null)
                    {
                        rowMsg.Append("交货数量为空;");
                    }
                    else
                    {
                        var cellValue = cell3.ToString().Trim();
                        if (cellValue == "")
                        {
                            rowMsg.Append("交货数量为空;");
                        }
                        var mng = string.Format("{0:f4}", cellValue);
                        if (!decimal.TryParse(mng, out menge))
                        {
                            rowMsg.Append("交货数量应为数字;");
                        }
                        else
                        {
                            if (mng.Length > 18)
                            {
                                rowMsg.Append("交货数量超出规定范围;");
                            }
                        }

                    }
                    var cell4 = row.GetCell(y + 4);
                    if (cell4 == null)
                    {
                        rowMsg.Append("批次为空;");
                    }
                    else
                    {
                        charge = cell4.ToString().Trim();
                        if (charge == "")
                        {
                            rowMsg.Append("批次为空;");
                        }
                        else
                        {
                            if (charge.Length > 10)
                            {
                                rowMsg.Append("批次长度不能超过10;");
                            }
                        }
                    }

                    var cell5 = row.GetCell(y + 5);
                    if (cell5 == null)
                    {
                        rowMsg.Append("生产日期为空;");
                    }
                    else
                    {
                        var cellValue5 = cell5.ToString().Trim();
                        if (cellValue5 == "")
                        {
                            rowMsg.Append("生产日期为空;");
                        }
                        else
                        {
                            if (!DateTime.TryParse(cellValue5, out HSDAT))
                            {
                                rowMsg.Append("生产日期格式不正确;");
                            }
                        }
                    }

                    var cell6 = row.GetCell(y + 6);
                    if (cell6 == null)
                    {
                        rowMsg.Append("有效日期为空;");
                    }
                    else
                    {
                        var cellValue6 = cell6.ToString().Trim();
                        if (cellValue6 == "")
                        {
                            rowMsg.Append("有效日期为空;");
                        }
                        else
                        {
                            if (!DateTime.TryParse(cellValue6, out VFDAT))
                            {
                                rowMsg.Append("有效日期格式不正确;");
                            }
                        }
                    }

                    var cell7 = row.GetCell(y + 7);
                    if (cell7 == null)
                    {
                        rowMsg.Append("包装数量为空;");
                    }
                    else
                    {
                        var cellValue = cell7.ToString().Trim();
                        if (cellValue == "")
                        {
                            rowMsg.Append("包装数量为空;");
                        }
                        if (!decimal.TryParse(string.Format("{0:f2}", cellValue), out pkgNumber))
                        {
                            rowMsg.Append("包装数量应为数字;");
                        }

                    }
                    var cell8 = row.GetCell(y + 8);
                    if (cell8 == null)
                    {
                        rowMsg.Append("箱数为空;");
                    }
                    else
                    {
                        var cellValue = cell8.ToString().Trim();
                        if (cellValue == "")
                        {
                            rowMsg.Append("箱数为空;");
                        }
                        if (!int.TryParse(cellValue, out pkg_AMOUNT))
                        {
                            rowMsg.Append("箱数应为整数;");
                        }
                        else
                        {
                            if (pkg_AMOUNT > 100)
                            {
                                rowMsg.Append("箱数数量不能超过100;");
                            }
                        }

                    }

                    var cell9 = row.GetCell(y + 9);
                    if (cell9 == null)
                    {
                        fptm = "";
                    }
                    else
                    {
                        fptm = cell9.ToString().Trim();
                    }

                    var cell10 = row.GetCell(y + 10);
                    if (cell10 == null)
                    {
                        rowMsg.Append("发票金额为空;");
                    }
                    else
                    {
                        var cellValue = cell10.ToString().Trim();
                        if (cellValue == "")
                        {
                            rowMsg.Append("发票金额为空;");
                        }
                        var jr = string.Format("{0:f4}", cellValue);
                        if (!decimal.TryParse(jr, out fpjr))
                        {
                            rowMsg.Append("发票金额应为数字;");
                        }
                        else
                        {
                            if (jr.Length > 15)
                            {
                                rowMsg.Append("发票金额超出规定长度;");
                            }
                        }

                    }

                    var cell11 = row.GetCell(y + 11);
                    if (cell11 == null)
                    {
                        rowMsg.Append("发票号码为空;");
                    }
                    else
                    {
                        fphm = cell11.ToString().Trim();
                        if (fphm == "")
                        {
                            rowMsg.Append("发票号码为空;");
                        }
                        else
                        {
                            if (fphm.Length > 20)
                            {
                                rowMsg.Append("发票号码字符长度不能超过20;");
                            }
                        }
                    }
                    var cell12 = row.GetCell(y + 12);
                    if (cell12 == null)
                    {
                        rowMsg.Append("发票日期为空;");
                    }
                    else
                    {
                        var cellValue12 = cell12.ToString().Trim();
                        if (cellValue12 == "")
                        {
                            rowMsg.Append("发票日期为空;");
                        }
                        else
                        {
                            if (!DateTime.TryParse(cellValue12, out FPRQ))
                            {
                                rowMsg.Append("发票日期格式不正确;");
                            }
                        }
                    }
                    // var pur_Entity=
                    var cell13 = row.GetCell(y + 13);
                    if (cell13 == null)
                    {
                        comments = "";
                    }
                    else
                    {
                        comments = cell13.ToString().Trim();
                    }
                    if (comments.Length > 1000)
                    {
                        rowMsg.Append("备注长度不能超过1000;");
                    }
                    #endregion

                    if (rowMsg.ToString() == "" && sbMsg.ToString() == "")
                    {
                        var PurEn = BizLogicObject_SCM_D_PURCHARSEPLAN.Proxy.Query(new CauseObject_SCM_D_PURCHARSEPLAN
                        {
                            EBELN = ebeln,
                            EBELP = ebelp,
                            LIFNR = SystemLogic.Proxy.CurrentUser.ACCOUNT
                        }).FirstOrDefault();
                        if (PurEn == null)
                        {
                            rowMsg.Append("不存在的此采购计划，请核对订单号！");

                        }
                        else
                        {
                            int IsAllow = BizLogicObject_SCM_D_PURCHARSEPLAN.Proxy.IsAllowAdd(ebeln, ebelp, menge, SystemLogic.Proxy.CurrentUser.ACCOUNT, PurEn.MATNR, charge, IsLimit, null);
                            if (IsAllow != 1)
                            {
                                rowMsg.Append("供应计划数量超出采购订单数量！");
                            }
                        }
                        if (rowMsg.ToString() == "" && sbMsg.ToString() == "" && SystemLogic.Proxy.CurrentUser != null)
                        {
                            #region 数据库保存
                            EntityObject_SCM_D_SUPPLYPLAN entity = new EntityObject_SCM_D_SUPPLYPLAN();
                            entity.GYSACCOUNT = SystemLogic.Proxy.CurrentUser.ACCOUNT;//供应商ID
                            entity.GYSNAME = SystemLogic.Proxy.CurrentUser.NAME;//供应商名称
                            entity.EEIND = PurEn.EINDT.Replace("-", "");
                            entity.BEDAT = PurEn.BEDAT.Replace("-", "");
                            //  var Name = Guid.NewGuid().ToString();
                            entity.STATUS = "0";//0新建 1确认
                            entity.INFORMED_STATE = "0";//整包装 初始状态为0
                            entity.UNINFORMED_STATE = "0";//散包装 初始状态为0
                            entity.FPJR = Convert.ToDecimal(PurEn.NETPR) * menge;//后台重新计算发票金额
                            entity.ID = Guid.NewGuid().ToString();
                            entity.CHARG = charge;
                            entity.COMMENTS = comments;
                            entity.EBELN = ebeln;
                            entity.FPBM = fptm;
                            entity.FPHM = fphm;
                            entity.FPRQ = FPRQ;
                            entity.GYJH = ebelp;
                            entity.HSDAT = HSDAT;
                            entity.LGORT = PurEn.LGORT;
                            entity.MATNR = PurEn.MATNR;
                            entity.MEINS = PurEn.MEINS;
                            entity.MENGE = menge;
                            entity.MSEHT = PurEn.MSEHT;
                            entity.NAME = PurEn.NAME;
                            entity.NETPR = PurEn.NETPR;
                            entity.ORDER_MENGE = PurEn.MENGE;
                            entity.PKG_AMOUNT = pkgNumber;//包装数量
                            entity.PKG_NUMBER = pkg_AMOUNT;//箱数
                            entity.TXZ01 = PurEn.TXZ01;
                            entity.VFDAT = VFDAT;
                            entity.WERKS = PurEn.WERKS;
                            entity.WERKST = PurEn.WERKST;

                            var msg = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Save(entity);
                            if (string.IsNullOrEmpty(entity.CODE))
                            {
                                rowMsg.Append("添加供应计划失败！");
                            }
                            else
                            {
                                list_supp_C.Add(entity);//上传SAP
                            }
                            #endregion

                        }

                    }
                    if (rowMsg.ToString() != "")
                    {
                        sbMsg.Append("第 " + i + " 行:");

                        sbMsg.Append(rowMsg.ToString() + Environment.NewLine);

                    }
                }
            }
            #region 增加供应计划到SAP
            if (list_supp_C.Count > 0)
            {
                //var msg = BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.BatchSave(list_supp_C.ToArray());
                if (sbMsg.ToString() != "")
                {
                    foreach (var en in list_supp_C)
                    {
                        BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Delete(en);//上传SAP失败后 删除数据
                    }
                }

                try
                {
                    RfcNOC rnc = new RfcNOC();
                    var List_Back = rnc.SendSupplyPlan("", list_supp_C, SystemLogic.Proxy.CurrentUser.ACCOUNT, SystemLogic.Proxy.CurrentUser.NAME, "0", "C");//SAP返回的列表
                    if (List_Back.Count == 0 || List_Back[0].MSTYPE != "S")
                    {
                        foreach (var en in list_supp_C)
                        {
                            BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Delete(en);//上传SAP失败后 删除数据

                        }
                        sbMsg.Append("保存到SAP数据失败！");
                    }
                    else
                    {
                        // sbMsg.Append("保存成功！");
                    }
                }
                catch (Exception ex)
                {
                    foreach (var en in list_supp_C)
                    {
                        BizLogicObject_SCM_D_SUPPLYPLAN.Proxy.Delete(en);//上传SAP失败后 删除数据

                    }
                    sbMsg.Append("保存数据失败:" + ex.Message);

                }

            }
            return sbMsg.ToString();
            #endregion
        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}