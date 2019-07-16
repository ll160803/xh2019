using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPOI.HSSF.UserModel;
using System.IO;
using NPOI.SS.UserModel;
using System.Linq.Expressions;
using System.Reflection;
using NPOI.SS.Util;
using System.Collections;
using NPOI.CSS;

namespace NFine.Code
{
    public class NPOIWriteExcel
    {
        /// <summary>
        /// 自定义模板，数据根据模板的最后一行的样式进行列表数据填入
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="queryData">数据列表</param>
        /// <param name="dicFields">列表字段</param>
        /// <param name="startIndex">开始写数据的行</param>
        /// <param name="xlsPath">模板（可以包含标题，表头等）</param>
        /// <param name="SavePath1">存储位置</param>
        /// <param name="xlsName">存储Excel名称</param>
        /// <param name="sheetName">excel's sheet name</param>
        /// <returns></returns>
        public static string OutputExcelByTemplate<T>(List<T> queryData, Dictionary<int, string> dicFields, int startIndex = 1, string xlsPath = @"~/up/供应计划.xls", string SavePath1 = @"up/", string xlsName = "供应计划", string sheetName = "Sheet1")
        {
            return WriteExcel(GenerateRowAndWriteData, queryData, dicFields, startIndex, xlsPath, SavePath1, xlsName, sheetName);
        }
        /// <summary>
        /// 单独设置Excel的样式，不需要模板
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="queryData"></param>
        /// <param name="dicFields"></param>
        /// <param name="caption"></param>
        /// <param name="xlsPath"></param>
        /// <param name="SavePath1"></param>
        /// <param name="xlsName"></param>
        /// <param name="sheetName"></param>
        /// <returns></returns>
        public static string OutputExcel<T>(List<T> queryData, Dictionary<int, HeaderAndFiled> dicFields, ExcelCaption caption, string xlsPath = @"~/template/template.xls", string SavePath1 = @"uploadfile/", string xlsName = "数据导出", string sheetName = "Sheet1")
        {
            return WriteExcel(GenerateData, queryData, dicFields, caption, xlsPath, SavePath1, xlsName, sheetName);
        }
        public static string WriteExcel<T>(Action<List<T>, Dictionary<int, string>, int, ISheet, IWorkbook> action, List<T> queryData, Dictionary<int, string> dicFields, int startIndex = 1, string xlsPath = @"~/up/供应计划.xls", string SavePath1 = @"up/", string xlsName = "供应计划", string sheetName = "Sheet1")
        {
            HSSFWorkbook _book = new HSSFWorkbook();
            FileStream file = new FileStream(System.Web.HttpContext.Current.Server.MapPath(xlsPath), FileMode.Open, FileAccess.Read);
            IWorkbook hssfworkbook = new HSSFWorkbook(file);
            string guid = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + xlsName;
            var SavePath = System.Web.HttpContext.Current.Server.MapPath("~/" + SavePath1);
            // string SavePath = "E:/";
            if (!Directory.Exists(SavePath))
            {
                Directory.CreateDirectory(SavePath);
            }
            string saveFileName = SavePath + guid + ".xls";
            #region 操作excel 写入数据  方法委托的形式
            ISheet sheet = hssfworkbook.GetSheet(sheetName);
            string Name = xlsName;
            HSSFRow row = sheet.GetRow(0) as HSSFRow;
            row.GetCell(0).SetCellValue(Name);
            row = sheet.GetRow(2) as HSSFRow;

            action(queryData, dicFields, startIndex, sheet, hssfworkbook);

            #endregion

            sheet.ForceFormulaRecalculation = true;
            using (FileStream fileWrite = new FileStream(saveFileName, FileMode.Create))
            {
                hssfworkbook.Write(fileWrite);
            }
            file.Dispose();
            return string.Format("../../{1}{0}.xls", guid, SavePath1);
        }

        public static string WriteExcel<T>(Action<List<T>, Dictionary<int, HeaderAndFiled>, int, ISheet, IWorkbook> action, List<T> queryData, Dictionary<int, HeaderAndFiled> dicFields, ExcelCaption caption, string xlsPath = @"~/up/供应计划.xls", string SavePath1 = @"up/", string xlsName = "供应计划", string sheetName = "Sheet1")
        {
            HSSFWorkbook _book = new HSSFWorkbook();
            FileStream file = new FileStream(System.Web.HttpContext.Current.Server.MapPath(xlsPath), FileMode.Open, FileAccess.Read);
            IWorkbook hssfworkbook = new HSSFWorkbook(file);
            string guid = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + xlsName;
            var SavePath = System.Web.HttpContext.Current.Server.MapPath("~/" + SavePath1);
            // string SavePath = "E:/";
            if (!Directory.Exists(SavePath))
            {
                Directory.CreateDirectory(SavePath);
            }
            string saveFileName = SavePath + guid + ".xls";
            #region 操作excel 写入数据  方法委托的形式
            ISheet sheet = hssfworkbook.GetSheet(sheetName);
            int RowIndex = 0;
            #region 添加报表表头
            if (caption != null && !string.IsNullOrEmpty(caption.CaptionName))
            {
                HSSFRow row = GetCurrentRow(sheet, RowIndex) as HSSFRow;
                if (caption.Height != 0)//第一行名字的高度
                {
                    row.Height = (short)(caption.Height * 20);
                }
                GetCellByRow(sheet, row, 0, caption.CaptionCss).SetCellValue(caption.CaptionName);
                for (int J = 1; J < dicFields.Keys.Count; J++)
                {//产生的行  每列做合并
                    GetCellByRow(sheet, row, J, caption.CaptionCss);
                }
                sheet.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(RowIndex, RowIndex, 0, dicFields.Keys.Count - 1));
                RowIndex++;
            }
            #endregion
            #region 添加列头

            HSSFRow rowColumn = GetCurrentRow(sheet, RowIndex) as HSSFRow;
            if (dicFields[0].HeightTitle != 0)//第一行名字的高度
            {
                rowColumn.Height = (short)(dicFields[0].HeightTitle * 20);
            }
            for (int J = 0; J < dicFields.Keys.Count; J++)
            {//
                GetCellByRow(sheet, rowColumn, J, dicFields[J].TitleCss).SetCellValue(dicFields[J].Title);
                if (dicFields[J].Width != 0)//设置每列的宽度
                {
                    sheet.SetColumnWidth(J, dicFields[J].Width * 256);
                }

            }
            RowIndex++;

            #endregion

            action(queryData, dicFields, RowIndex, sheet, hssfworkbook);

            #endregion

            sheet.ForceFormulaRecalculation = true;
            using (FileStream fileWrite = new FileStream(saveFileName, FileMode.Create))
            {
                hssfworkbook.Write(fileWrite);
            }
            file.Dispose();
            return string.Format("../../../{1}{0}.xls", guid, SavePath1);
        }

        /// <summary>
        /// 获取当前行 没有则创建
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        public static HSSFRow GetCurrentRow(ISheet sheet, int rowIndex)
        {
            HSSFRow dataRowColumn = sheet.GetRow(rowIndex) as HSSFRow;
            if (dataRowColumn == null)
            {
                dataRowColumn = sheet.CreateRow(rowIndex) as HSSFRow;
            }
            return dataRowColumn;
        }

        public static ICell GetCellByRow(ISheet sheet, HSSFRow hSSFRow, int cellIndex, string css = "")
        {
            var cell = hSSFRow.GetCell(cellIndex) ?? hSSFRow.CreateCell(cellIndex);
            if (css != "")
            {
                cell.CSS(css);
            }
            return cell;
        }

        /// <summary>
        /// 默认情况下执行的excel写入操作 对应WriteExcel 的Action参数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="queryData"></param>
        /// <param name="dicFields"></param>
        /// <param name="startIndex"></param>
        /// <param name="sheet"></param>
        /// <param name="hssfworkbook"></param>
        public static void GenerateRowAndWriteData<T>(List<T> queryData, Dictionary<int, string> dicFields, int startIndex, ISheet sheet, IWorkbook hssfworkbook)
        {
            //标题行 默认  开始行  
            int stratIndex = startIndex;//开始行 
            int RowIndex = stratIndex + 1;//excel输出到的当前行数
            ArrayList arrStyle = new ArrayList();
            for (int i = 0; i < queryData.Count; i++)
            {
                //  HSSFRow dataRowColumn = GetCurrentRow(sheet, RowIndex);
                GetCurrentCellStyle(sheet, hssfworkbook, ref RowIndex, stratIndex + 1, dicFields.Keys.Count, arrStyle);
                SetExcelValue<T>(queryData[i], dicFields, sheet, hssfworkbook, ref RowIndex, stratIndex + 1);
                RowIndex += 1;
            }

        }
        public static void GenerateData<T>(List<T> queryData, Dictionary<int, HeaderAndFiled> dicFields, int RowIndex, ISheet sheet, IWorkbook hssfworkbook)
        {
            for (int i = 0; i < queryData.Count; i++)
            {
                //  HSSFRow dataRowColumn = GetCurrentRow(sheet, RowIndex);
                SetExcelValueAndCss<T>(queryData[i], dicFields, sheet, hssfworkbook, ref RowIndex);
                RowIndex += 1;
            }

        }

        public static void SetCellRangeAddress(ISheet sheet, int rowstart, int rowend, int colstart, int colend)
        {
            CellRangeAddress cellRangeAddress = new CellRangeAddress(rowstart, rowend, colstart, colend);
            sheet.AddMergedRegion(cellRangeAddress);
        }


        /// <summary>
        /// 创建cell 并初始化他的样式 样式默认和第一行数据一致 
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="row"></param>
        /// <param name="hssfworkbook"></param>
        /// <param name="rowIndex"></param>
        /// <param name="startRowIndex"></param>
        /// <param name="columnCount"></param>
        public static void GetCurrentCellStyle(ISheet sheet, IWorkbook hssfworkbook, ref int rowIndex, int startRowIndex, int columnCount, ArrayList arrStyle, int j = 0)
        {
            if (rowIndex > startRowIndex)
            {//第一行的样式 默认  其他行的样式模拟第一行的样式
                for (int i = 0; i < columnCount; i++)
                {
                    if (arrStyle.Count < i + 1)
                    {
                        var style3 = hssfworkbook.CreateCellStyle();
                        style3.CloneStyleFrom(GetCurrentRow(sheet, startRowIndex).Cells[i].CellStyle);
                        arrStyle.Add(style3);
                    }
                    var cell3 = GetCurrentRow(sheet, rowIndex + j).GetCell(i) ?? GetCurrentRow(sheet, rowIndex + j).CreateCell(i);
                    //  var style3 = hssfworkbook.CreateCellStyle();
                    //  style3.CloneStyleFrom(GetCurrentRow(sheet, startRowIndex).Cells[i].CellStyle);
                    cell3.CellStyle = arrStyle[i] as ICellStyle;
                }
            }

        }
        public static void SetExcelValueAndCss<T>(T ModelData, Dictionary<int, HeaderAndFiled> dicFields, ISheet sheet, IWorkbook hssfworkbook, ref int rowIndex)
        {
            int CurrentRow = rowIndex;
            HSSFRow dataRowColumn = GetCurrentRow(sheet, rowIndex);
            if (dicFields[0].Height != 0)//第一行名字的高度
            {
                dataRowColumn.Height = (short)(dicFields[0].Height * 20);
            }
            for (int i = 0; i < dicFields.Keys.Count; i++)
            {
                var cellCur = GetCellByRow(sheet, dataRowColumn, i, dicFields[i].FieldCss);
                var fieldName = dicFields[i].Field;
                Type columnType = typeof(string);
                var cellValue = GetValueByFieldOrPerperty<T>(ModelData, fieldName, ref columnType);
                if (cellValue == null)
                {
                    continue;
                }
                switch (columnType.ToString())
                {
                    case "System.String"://当所写的字符串太多，合并行
                        float lastHeight;
                        var NeedRow = CalcExcelRowsCount.GetCountByString((string)cellValue, sheet.GetColumnWidth(i) / 256, out lastHeight);//字符串可能占用的行数
                        if (NeedRow > 1)
                        {
                            dataRowColumn.HeightInPoints = 409f;//先把第一行设置为409f 最大
                            for (int k = 2; k <= NeedRow; k++)
                            {
                                rowIndex += 1;

                                if (k == NeedRow)
                                {
                                    sheet.GetRow(rowIndex).HeightInPoints = lastHeight;
                                }
                                else
                                {
                                    sheet.GetRow(rowIndex).HeightInPoints = 409f;
                                }
                            }
                            for (int J = 0; J < dicFields.Keys.Count; J++)
                            {//产生的行  每列做合并
                                sheet.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(CurrentRow, rowIndex, J, J));
                            }
                        }
                        cellCur.CellStyle.WrapText = true;//默认字符串都可以换行
                        cellCur.SetCellValue((string)cellValue);
                        break;
                    case "System.DateTime":
                        DateTime dateV = cellValue;
                        cellCur.SetCellValue(dateV.ToString("yyyy-MM-dd"));
                        break;
                    case "System.Boolean":
                        //bool boolV = false;
                        if (cellValue)
                        {
                            cellCur.SetCellValue("是");
                        }
                        else
                        {
                            cellCur.SetCellValue("否");
                        }
                        //bool.TryParse(cellValue, out boolV);
                        //cellCur.SetCellValue(boolV);
                        break;
                    case "System.Int16":
                    case "System.Int32":
                    case "System.Int64":
                    case "System.Byte":
                        cellCur.SetCellValue(cellValue);
                        break;
                    case "System.Double":
                    case "System.Decimal":
                    case "System.signle":
                        cellCur.SetCellValue((double)cellValue);
                        break;
                    case "System.DBNull":

                        break;
                    case "System.Guid":
                        cellCur.SetCellValue(cellValue.ToString());
                        break;
                    default:

                        break;
                }




            }
        }
        /// <summary>
        /// 给每行的cell赋值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ModelData"></param>
        /// <param name="dicFields"></param>
        /// <param name="sheet"></param>
        /// <param name="rowIndex"></param>
        public static void SetExcelValue<T>(T ModelData, Dictionary<int, string> dicFields, ISheet sheet, IWorkbook hssfworkbook, ref int rowIndex, int startRowIndex)
        {
            int CurrentRow = rowIndex;
            HSSFRow dataRowColumn = GetCurrentRow(sheet, rowIndex);
            for (int i = 0; i < dicFields.Keys.Count; i++)
            {
                var fieldName = dicFields[i];
                Type columnType = typeof(string);
                var cellValue = GetValueByFieldOrPerperty<T>(ModelData, fieldName, ref columnType);
                if (cellValue == null)
                {
                    continue;
                }
                switch (columnType.ToString())
                {
                    case "System.String"://当所写的字符串太多，合并行
                        float lastHeight;
                        var NeedRow = CalcExcelRowsCount.GetCountByString((string)cellValue, sheet.GetColumnWidth(i) / 256, out lastHeight);//字符串可能占用的行数
                        if (NeedRow > 1)
                        {
                            dataRowColumn.HeightInPoints = 409f;//先把第一行设置为409f 最大
                            for (int k = 2; k <= NeedRow; k++)
                            {
                                rowIndex += 1;
                                ArrayList arrStyle = new ArrayList();
                                GetCurrentCellStyle(sheet, hssfworkbook, ref rowIndex, startRowIndex, dicFields.Keys.Count, arrStyle);
                                if (k == NeedRow)
                                {
                                    sheet.GetRow(rowIndex).HeightInPoints = lastHeight;
                                }
                                else
                                {
                                    sheet.GetRow(rowIndex).HeightInPoints = 409f;
                                }
                            }
                            for (int J = 0; J < dicFields.Keys.Count; J++)
                            {//产生的行  每列做合并
                                sheet.AddMergedRegion(new NPOI.SS.Util.CellRangeAddress(CurrentRow, rowIndex, J, J));
                            }
                        }
                        dataRowColumn.Cells[i].SetCellValue((string)cellValue);
                        break;
                    case "System.DateTime":
                        DateTime dateV = cellValue;
                        dataRowColumn.Cells[i].SetCellValue(dateV.ToShortDateString().ToString());
                        break;
                    case "System.Boolean":
                        bool boolV = false;
                        bool.TryParse(cellValue, out boolV);
                        dataRowColumn.Cells[i].SetCellValue(boolV);
                        break;
                    case "System.Int16":
                    case "System.Int32":
                    case "System.Int64":
                    case "System.Byte":
                        dataRowColumn.Cells[i].SetCellValue(cellValue);
                        break;
                    case "System.Double":
                    case "System.Decimal":
                    case "System.signle":
                        dataRowColumn.Cells[i].SetCellValue((double)cellValue);
                        break;
                    case "System.DBNull":

                        break;
                    case "System.Guid":
                        dataRowColumn.Cells[i].SetCellValue(cellValue.ToString());
                        break;
                    default:

                        break;
                }




            }
        }
        /// <summary>
        /// 反射属性的值 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ModelData"></param>
        /// <param name="FieldName"></param>
        /// <param name="columnType"></param>
        /// <returns></returns>
        public static dynamic GetValueByFieldOrPerperty<T>(T ModelData, string FieldName, ref Type columnType)
        {

            if (FieldName.Contains("."))
            {

                string[] arr = FieldName.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                if (arr.Length != 2)
                {
                    return null;
                }
                PropertyInfo Filed = typeof(T).GetProperty(arr[0]);
                if (Filed == null)
                {
                    return null;
                }
                //foreach (var Filed in Fileds) {
                //    if (Filed.Name.Contains(arr[0])) {
                var filedValue = Filed.GetValue(ModelData, null);
                if (filedValue == null)
                {
                    return null;
                }
                PropertyInfo FieldsPro = Filed.PropertyType.GetProperty(arr[1]);
                if (FieldsPro == null)
                {
                    return null;
                }
                var returnValue = FieldsPro.GetValue(filedValue, null);

                columnType = FieldsPro.PropertyType;

                // We need to check whether the property is NULLABLE
                if (FieldsPro.PropertyType.IsGenericType && FieldsPro.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    // If it is NULLABLE, then get the underlying type. eg if "Nullable<int>" then this will return just "int"
                    columnType = FieldsPro.PropertyType.GetGenericArguments()[0];
                }
                return (dynamic)returnValue;
                // }


            }
            else
            {
                PropertyInfo FieldsPro = typeof(T).GetProperty(FieldName);
                if (FieldsPro == null)
                {

                    return null;
                }
                //  var cellValue= f.GetValue(ModelData, null);
                //   MemberExpression mem = Expression.Property(p, f);//p.f
                // var done=(Func<dynamic>) Delegate.CreateDelegate(typeof(Func<dynamic>), ModelData, f.GetGetMethod());
                //var lam = Expression.Lambda<Func<T, dynamic>>(Expression.Convert(mem, typeof(object)), p);
                //var done = lam.Compile();
                var cellValue = (dynamic)FieldsPro.GetValue(ModelData, null);
                columnType = FieldsPro.PropertyType;

                // We need to check whether the property is NULLABLE
                if (FieldsPro.PropertyType.IsGenericType && FieldsPro.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    // If it is NULLABLE, then get the underlying type. eg if "Nullable<int>" then this will return just "int"
                    columnType = FieldsPro.PropertyType.GetGenericArguments()[0];
                }
                return cellValue;
            }
        }
    }
}
