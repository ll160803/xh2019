using System;
using System.Collections.Generic;
using System.Text;

namespace XH_Print
{
    public class infoposition
    {
        /// <summary>
        /// 第几行
        /// </summary>
        public int indexRow { get; set; }
        /// <summary>
        /// 第几列
        /// </summary>
        public int indexCol { get; set; }
        /// <summary>
        /// 打印的x位置
        /// </summary>
        public int posX { get; set; }
        /// <summary>
        /// 打印的y位置
        /// </summary>
        public int posY { get; set; }
        /// <summary>
        /// 打印的内容
        /// </summary>
        public string infoValue { get; set; }

        /// <summary>
        /// 打印字体大小
        /// </summary>
        public int fontSize
        {
            get;
            set;
        }
        public int bold { get; set; }
    }
}
