using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Code
{
    public class HeaderAndFiled
    {
        /// <summary>
        ///  字段显示名称
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 字段的类属性
        /// </summary>
        public string Field { get; set; }

        private string _FieldCss;
        /// <summary>
        /// 每一个导出的列的css
        /// </summary>
        public string FieldCss
        {
            get
            {
                if (string.IsNullOrEmpty(_FieldCss))
                {
                    return "font-size:10;font-name:宋体;border-type:thin;";
                }
                return _FieldCss;
            }
            set
            {
                _FieldCss = value;
            }

        }
        private string _titleCss;
        /// <summary>
        /// 每一个导出的列头的css
        /// </summary>
        public string TitleCss
        {
            get
            {
                if (string.IsNullOrEmpty(_titleCss))
                {
                    return "text-align:center;font-size:10;font-name:宋体;border-type:thin;font-weight:bold;";
                }
                return _titleCss;
            }
            set
            {
                _titleCss = value;
            }

        }
        private int width;
        /// <summary>
        /// *256
        /// </summary>
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        private int height;
        /// <summary>
        /// *20 数据行的高度
        /// </summary>
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }


        private int heightTitle;
        /// <summary>
        /// *20 标题的高度
        /// </summary>
        public int HeightTitle
        {
            get
            {
                return heightTitle;
            }
            set
            {
                heightTitle = value;
            }
        }
    }
    public class ExcelCaption
    {
        /// <summary>
        /// Excel导出的标题
        /// </summary>
        public string CaptionName { get; set; }

        private string captionCss;
        /// <summary>
        /// Excel导出标题的样式 这里稍后设置默认样式
        /// </summary>
        public string CaptionCss
        {
            get
            {
                if (string.IsNullOrEmpty(captionCss))
                {
                    return "text-align:center;font-size:20;font-name:宋体;border-type:thin;font-weight:bold;";
                }
                return captionCss;
            }
            set
            {
                captionCss = value;
            }
        }
        private int height;
        /// <summary>
        /// *20
        /// </summary>
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

    }
    public class HandleTitelAndField
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="titleandfield"></param>
        /// <param name="width">列宽</param>
        /// <param name="height">数据行高</param>
        /// <param name="heightTitle">列名行高</param>
        /// <returns></returns>
        public static Dictionary<int, HeaderAndFiled> GetTitleAndField(string titleandfield, int width=0,int height=0, int heightTitle=0)
        {
            List<HeaderAndFiled> listData = new List<HeaderAndFiled>();

            listData = titleandfield.ToList<HeaderAndFiled>();
            Dictionary<int, HeaderAndFiled> dicFields = new Dictionary<int, HeaderAndFiled>();
            int key = 0;
            foreach (var item in listData)
            {
                dicFields.Add(key, new HeaderAndFiled { Field = item.Field, Title = item.Title, Height = height, HeightTitle = heightTitle, Width= width });
                key++;
            }
            return dicFields;
        }
    }
}
