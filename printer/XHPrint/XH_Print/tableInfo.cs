using System;
using System.Collections.Generic;
using System.Text;

namespace XH_Print
{
    public class TableInfo
    {
        /// <summary>
        /// 列数
        /// </summary>
        public int yc;
        /// <summary>
        /// 行数
        /// </summary>
        public int xc;
        /// <summary>
        /// 一列宽度
        /// </summary>
        public int width;
        /// <summary>
        /// 一行高度
        /// </summary>
        public int height;
        /// <summary>
        /// 表格的初始化X
        /// </summary>
        public int initX;
        /// <summary>
        /// 表格的初始化Y
        /// </summary>
        public int initY;
        /// <summary>
        /// 表格首列宽度
        /// </summary>
        public int firstWidth;
        /// <summary>
        /// 是否横向打印   false 丛向  true 横向
        /// </summary>
        public bool IsHeng = false;
    }
}
