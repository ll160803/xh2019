using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace Ipedf.Hrp.BGT.Utility
{
    public class SheetClone
    {
        public static void CopyCellStyle(IWorkbook wb, ICellStyle fromStyle, ICellStyle toStyle)
        {
            //toStyle.Alignment = fromStyle.Alignment;
            ////边框和边框颜色  
            //toStyle.BorderBottom = fromStyle.BorderBottom;
            //toStyle.BorderLeft = fromStyle.BorderLeft;
            //toStyle.BorderRight = fromStyle.BorderRight;
            //toStyle.BorderTop = fromStyle.BorderTop;
            //toStyle.TopBorderColor = fromStyle.TopBorderColor;
            //toStyle.BottomBorderColor = fromStyle.BottomBorderColor;
            //toStyle.RightBorderColor = fromStyle.RightBorderColor;
            //toStyle.LeftBorderColor = fromStyle.LeftBorderColor;

            ////背景和前景  
            //toStyle.FillBackgroundColor = fromStyle.FillBackgroundColor;
            //toStyle.FillForegroundColor = fromStyle.FillForegroundColor;

            //toStyle.DataFormat = fromStyle.DataFormat;
            //toStyle.FillPattern = fromStyle.FillPattern;
            ////toStyle.Hidden=fromStyle.Hidden;  
            //toStyle.IsHidden = fromStyle.IsHidden;
            //toStyle.Indention = fromStyle.Indention;//首行缩进  
            //toStyle.IsLocked = fromStyle.IsLocked;
            //toStyle.Rotation = fromStyle.Rotation;//旋转  
            //toStyle.VerticalAlignment = fromStyle.VerticalAlignment;
            //toStyle.WrapText = fromStyle.WrapText;
            //toStyle.SetFont(fromStyle.GetFont(wb));
            
            toStyle.CloneStyleFrom(fromStyle);
        }

        /// <summary>  
        /// 复制表  
        /// </summary>  
        /// <param name="wb"></param>  
        /// <param name="fromSheet"></param>  
        /// <param name="toSheet"></param>  
        /// <param name="copyValueFlag"></param>  
        public static void CopySheet(IWorkbook wb, ISheet fromSheet, ISheet toSheet, bool copyValueFlag)
        {
            //合并区域处理  
            MergerRegion(fromSheet, toSheet);
            System.Collections.IEnumerator rows = fromSheet.GetRowEnumerator();
            int i=0;
            while (rows.MoveNext())
            {
                IRow row = null;
                if (wb is HSSFWorkbook)
                    row = rows.Current as HSSFRow;
                else
                    row = rows.Current as NPOI.XSSF.UserModel.XSSFRow;
                IRow newRow = toSheet.CreateRow(row.RowNum);
                toSheet.SetColumnWidth(i, fromSheet.GetColumnWidth(i));
               
                i = i + 1;
              
                CopyRow(wb, row, newRow, copyValueFlag);
            }
        }

        public static void CopySheet(IWorkbook wb, ISheet fromSheet, ISheet toSheet, bool copyValueFlag, ICellStyle newstyle)
        {
            //合并区域处理  
            MergerRegion(fromSheet, toSheet);
            System.Collections.IEnumerator rows = fromSheet.GetRowEnumerator();
            int i = 0;
            while (rows.MoveNext())
            {
                IRow row = null;
                if (wb is HSSFWorkbook)
                    row = rows.Current as HSSFRow;
                else
                    row = rows.Current as NPOI.XSSF.UserModel.XSSFRow;
                IRow newRow = toSheet.CreateRow(row.RowNum);
                toSheet.SetColumnWidth(i, fromSheet.GetColumnWidth(i));

                i = i + 1;

                CopyRow(wb, row, newRow, copyValueFlag, newstyle);
            }
        }

        /// <summary>  
        /// 复制行  
        /// </summary>  
        /// <param name="wb"></param>  
        /// <param name="fromRow"></param>  
        /// <param name="toRow"></param>  
        /// <param name="copyValueFlag"></param>  
        public static void CopyRow(IWorkbook wb, IRow fromRow, IRow toRow, bool copyValueFlag)
        {
            System.Collections.IEnumerator cells = fromRow.GetEnumerator(); //.GetRowEnumerator();  
           // toRow.Height = fromRow.Height;
            while (cells.MoveNext())
            {
                ICell cell = null;
                //ICell cell = (wb is HSSFWorkbook) ? cells.Current as HSSFCell : cells.Current as NPOI.XSSF.UserModel.XSSFCell;  
                if (wb is HSSFWorkbook)
                    cell = cells.Current as HSSFCell;
                else
                    cell = cells.Current as NPOI.XSSF.UserModel.XSSFCell;
                ICell newCell = toRow.CreateCell(cell.ColumnIndex);
                CopyCell(wb, cell, newCell, copyValueFlag);
            }
        }

        public static void CopyRow(IWorkbook wb, IRow fromRow, IRow toRow, bool copyValueFlag, ICellStyle newstyle)
        {
            System.Collections.IEnumerator cells = fromRow.GetEnumerator(); //.GetRowEnumerator();  
            // toRow.Height = fromRow.Height;
            while (cells.MoveNext())
            {
                ICell cell = null;
                //ICell cell = (wb is HSSFWorkbook) ? cells.Current as HSSFCell : cells.Current as NPOI.XSSF.UserModel.XSSFCell;  
                if (wb is HSSFWorkbook)
                    cell = cells.Current as HSSFCell;
                else
                    cell = cells.Current as NPOI.XSSF.UserModel.XSSFCell;
                ICell newCell = toRow.CreateCell(cell.ColumnIndex);
                CopyCell(wb, cell, newCell, copyValueFlag, newstyle);
            }
        }


        /// <summary>  
        /// 复制原有sheet的合并单元格到新创建的sheet  
        /// </summary>  
        /// <param name="fromSheet"></param>  
        /// <param name="toSheet"></param>  
        public static void MergerRegion(ISheet fromSheet, ISheet toSheet)
        {
            int sheetMergerCount = fromSheet.NumMergedRegions;
            for (int i = 0; i < sheetMergerCount; i++)
            {
                //Region mergedRegionAt = fromSheet.GetMergedRegion(i); //.MergedRegionAt(i);  
                //CellRangeAddress[] cra = new CellRangeAddress[1];  
                //cra[0] = fromSheet.GetMergedRegion(i);  
                //Region[] rg = Region.ConvertCellRangesToRegions(cra);  
                toSheet.AddMergedRegion(fromSheet.GetMergedRegion(i));
            }
        }

        /// <summary>  
        /// 复制单元格  
        /// </summary>  
        /// <param name="wb"></param>  
        /// <param name="srcCell"></param>  
        /// <param name="distCell"></param>  
        /// <param name="copyValueFlag"></param>  
        public static void CopyCell(IWorkbook wb, ICell srcCell, ICell distCell, bool copyValueFlag)
        {
            ICellStyle newstyle = wb.CreateCellStyle();
            CopyCellStyle(wb, srcCell.CellStyle, newstyle);

            //样式  
            distCell.CellStyle = newstyle;
            
            //评论  
            if (srcCell.CellComment != null)
            {
                distCell.CellComment = srcCell.CellComment;
            }
            // 不同数据类型处理  
            CellType srcCellType = srcCell.CellType;
            distCell.SetCellType(srcCellType);
            if (copyValueFlag)
            {
                if (srcCellType == CellType.Numeric)
                {

                    if (HSSFDateUtil.IsCellDateFormatted(srcCell))
                    {
                        distCell.SetCellValue(srcCell.DateCellValue);
                    }
                    else
                    {
                        distCell.SetCellValue(srcCell.NumericCellValue);
                    }
                }
                else if (srcCellType == CellType.String)
                {
                    distCell.SetCellValue(srcCell.RichStringCellValue);
                }
                else if (srcCellType == CellType.Blank)
                {
                    // nothing21  
                }
                else if (srcCellType == CellType.Boolean)
                {
                    distCell.SetCellValue(srcCell.BooleanCellValue);
                }
                else if (srcCellType == CellType.Error)
                {
                    distCell.SetCellErrorValue(srcCell.ErrorCellValue);
                }
                else if (srcCellType == CellType.Formula)
                {
                    distCell.SetCellFormula(srcCell.CellFormula);
                }
                else
                { // nothing29  
                }
            }
        }

        /// <summary>  
        /// 复制单元格  
        /// </summary>  
        /// <param name="wb"></param>  
        /// <param name="srcCell"></param>  
        /// <param name="distCell"></param>  
        /// <param name="copyValueFlag"></param>  
        public static void CopyCell(IWorkbook wb, ICell srcCell, ICell distCell, bool copyValueFlag, ICellStyle newstyle)
        {
            CopyCellStyle(wb, srcCell.CellStyle, newstyle);

            //样式  
            distCell.CellStyle = newstyle;

            //评论  
            if (srcCell.CellComment != null)
            {
                distCell.CellComment = srcCell.CellComment;
            }
            // 不同数据类型处理  
            CellType srcCellType = srcCell.CellType;
            distCell.SetCellType(srcCellType);
            if (copyValueFlag)
            {
                if (srcCellType == CellType.Numeric)
                {

                    if (HSSFDateUtil.IsCellDateFormatted(srcCell))
                    {
                        distCell.SetCellValue(srcCell.DateCellValue);
                    }
                    else
                    {
                        distCell.SetCellValue(srcCell.NumericCellValue);
                    }
                }
                else if (srcCellType == CellType.String)
                {
                    distCell.SetCellValue(srcCell.RichStringCellValue);
                }
                else if (srcCellType == CellType.Blank)
                {
                    // nothing21  
                }
                else if (srcCellType == CellType.Boolean)
                {
                    distCell.SetCellValue(srcCell.BooleanCellValue);
                }
                else if (srcCellType == CellType.Error)
                {
                    distCell.SetCellErrorValue(srcCell.ErrorCellValue);
                }
                else if (srcCellType == CellType.Formula)
                {
                    distCell.SetCellFormula(srcCell.CellFormula);
                }
                else
                { // nothing29  
                }
            }
        }
    }  
}
