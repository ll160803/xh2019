using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPOI.SS.UserModel;
using System.Web;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;

namespace Ipedf.Web.Common
{
    public class NPOIReadExcel
    {
        public static string ReadExcelAndCheck(Func<ISheet, IWorkbook, int, string> action, HttpPostedFile postFile, string savePath, int startIndex = 1, string sheetName = "Sheet1")
        {
            string msg = "";
            string fileName = Guid.NewGuid().ToString() + postFile.FileName;
            string filePath = savePath + fileName;
            try
            {
                postFile.SaveAs(filePath);

                ISheet sheet = null;
                FileStream fs = null;
                IWorkbook workbook = null;
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                if (filePath.IndexOf(".xlsx") > 0) // 2007版本
                    workbook = new XSSFWorkbook(fs);
                else if (filePath.IndexOf(".xls") > 0) // 2003版本
                    workbook = new HSSFWorkbook(fs);

                if (sheetName != null)
                {
                    sheet = workbook.GetSheet(sheetName);
                    if (sheet == null) //如果没有找到指定的sheetName对应的sheet，则尝试获取第一个sheet
                    {
                        sheet = workbook.GetSheetAt(0);
                    }
                }
                else
                {
                    sheet = workbook.GetSheetAt(0);
                }
                // bool IsCheck;
                msg = action(sheet, workbook, startIndex);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            finally
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
            }

            return msg;
        }
    }
}
