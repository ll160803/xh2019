using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ipedf.Web.Entity;
using Ipedf.Web.BizLogic;
using Ipedf.Common;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;
using System.Data;

namespace Ipedf.Hrp.BGT.Utility
{
    public class ImportUtil
    {
        public static DataTable ExcelToDataTable(string filePath)
        {
            return ExcelToDataTable(filePath, null, true);
        }
        public static void AppendCheckResultToExcel(string filePath, List<string> colMsg)
        {
            AppendCheckResultToExcel(filePath, null, colMsg);
        }
        public static DataTable ExcelToDataTable(string filePath, string sheetName, bool isFirstRowColumn)
        {
            ISheet sheet = null;
            DataTable data = new DataTable();
            int startRow = 0;
            FileStream fs = null;
            IWorkbook workbook = null;
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                if (filePath.IndexOf(".xlsx") > 0) // 2007版本
                    workbook = new XSSFWorkbook(fs);
                else if (filePath.IndexOf(".xls") > 0) // 2003版本
                    workbook = new HSSFWorkbook(fs);
                else
                {
                    fs.Close();
                    throw new Exception("请选择正确的Excel文件.");
                }

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
                if (sheet != null)
                {
                    IRow firstRow = sheet.GetRow(0);
                    int cellCount = firstRow.LastCellNum; //第一行最后一个cell的编号 即总的列数

                    if (isFirstRowColumn)
                    {
                        for (int i = firstRow.FirstCellNum; i < cellCount; ++i)
                        {
                            ICell cell = firstRow.GetCell(i);
                            if (cell != null)
                            {
                                string cellValue = cell.StringCellValue;
                                if (cellValue != null)
                                {
                                    DataColumn column = new DataColumn(cellValue);
                                    data.Columns.Add(column);
                                }
                            }
                        }
                        startRow = sheet.FirstRowNum + 1;
                    }
                    else
                    {
                        startRow = sheet.FirstRowNum;
                    }

                    //最后一列的标号
                    int rowCount = sheet.LastRowNum;
                    for (int i = startRow; i <= rowCount; ++i)
                    {
                        IRow row = sheet.GetRow(i);
                        DataRow dataRow = data.NewRow();
                        if (row == null)
                        {
                            data.Rows.Add(dataRow);
                            continue;
                        }

                        StringBuilder sb = new StringBuilder();

                        for (int j = row.FirstCellNum; j < cellCount; ++j)
                        {
                            if (row.GetCell(j) != null) //同理，没有数据的单元格都默认是null
                            {
                                dataRow[j] = row.GetCell(j).ToString();
                                sb.Append(dataRow[j]);
                            }
                        }

                        if (sb.ToString().Trim().Length > 0)
                        {
                            data.Rows.Add(dataRow);
                        }
                        
                    }
                }

                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
                if (workbook != null)
                {
                    workbook.Close();
                }
            }
        }
        public static void AppendCheckResultToExcel(string filePath, string sheetName, List<string> colMsg)
        {
            FileStream fs = null;
            IWorkbook workbook = null;
            ISheet sheet = null;
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                if (filePath.IndexOf(".xlsx") > 0) // 2007版本
                    workbook = new XSSFWorkbook(fs);
                else if (filePath.IndexOf(".xls") > 0) // 2003版本
                    workbook = new HSSFWorkbook(fs);
                else
                {
                    fs.Close();
                    throw new Exception("请选择正确的Excel文件.");
                }

                if (sheetName != null)
                {
                    sheet = workbook.GetSheet(sheetName);
                    if (sheet == null) //如果没有找到指定的sheetName对应的sheet，则尝试获取第一个sheet
                    {
                        sheet = workbook.GetSheetAt(0);
                    }
                }
                IRow headerRow = sheet.GetRow(0);             //获取表头
                int rowNum = sheet.LastRowNum;                //行数
                int colNum = headerRow.LastCellNum;             //列数
                IRow dataRow = null;                          //遍历行

                //填充检测结果内容
                for (int i = 0; i < rowNum; i++)
                {
                    dataRow = sheet.GetRow(i + 1);
                    dataRow.Cells[colNum - 1].SetCellValue(colMsg[i + 1]);
                }
                //保存   
                fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                workbook.Write(fs);
                fs.Close();
                workbook.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
                if (workbook != null)
                {
                    workbook.Close();
                }
            }
        }
    }
}
