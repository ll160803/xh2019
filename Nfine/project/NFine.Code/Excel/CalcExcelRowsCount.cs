using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using NPOI.SS.UserModel;

namespace NFine.Code
{
    public class CalcExcelRowsCount {
        /// <summary>
        /// 一行文字所能产生的行数 (没有换行)
        /// </summary>
        /// <param name="p">一行中的文字</param>
        /// <param name="columnWidth">excel中输入数字的宽度</param>
        /// <returns></returns>
        public static int GetStringCount(string p, int columnWidth) {
            int result = 1;
            if (string.IsNullOrEmpty(p)) {
                return 1;
            }

            //  int columnWidth = sheet.GetColumnWidth(columnIndex) / 256;
            var str = p.ToString();
            var countHz = Regex.Matches(str, @"[\u4e00-\u9fa5]").Count;//汉字的个数
            var otherCount = str.Length - countHz;
            var length = countHz * 2 + otherCount;

            result = (int)(length / columnWidth) + 1;
            return result;

        }
        /// <summary>
        /// 一段文字所能产生的行数 （有一个或多个换行）
        /// </summary>
        /// <param name="fieldStr"></param>
        /// <param name="columnWidth"></param>
        /// <returns></returns>
        public static int GetRowsCount(string fieldStr, int columnWidth) {
            if (fieldStr.Length > 1) {
                string[] arr = fieldStr.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                int RowCount = 0;
                foreach (string item in arr) {
                    RowCount += GetStringCount(item, columnWidth);
                }
                return RowCount;
            }
            return 1;
        }
        /// <summary>
        /// 需要使用的excel的行数 如果为2行，则前两行为409，最后一行为lastheight
        /// </summary>
        /// <param name="rowCount"></param>
        /// <param name="height"></param>
        /// <param name="lastheight">最后一行的高度</param>
        /// <returns></returns>
        public static int GetRowCountAndHeight(int rowCount, int height, out float lastheight) {

            int number = 0;
            number = rowCount * height / 409;
            if (number == 0) {
                lastheight = 0;
            }
            else {
                lastheight = rowCount * height - number * 409;
            }

            return number + 1;
        }
        public static int GetCountByString(string fieldValue, int columnWidth, out float lastheight, int height = 12) {

            int rowCount = GetRowsCount(fieldValue, columnWidth);
            return GetRowCountAndHeight(rowCount, height, out lastheight);
        }
    }
}
