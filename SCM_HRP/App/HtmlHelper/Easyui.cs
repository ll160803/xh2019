using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    /// <summary>
    /// easyui中的datagrid
    /// </summary>
    public class datagrid
    {
        /// <summary>
        /// 总数
        /// </summary>
        public int total;

        /// <summary>
        /// 页脚
        /// </summary>
        public dynamic footer;

        /// <summary>
        /// 行数据集
        /// </summary>
        public dynamic rows;
    }
    /// <summary>
    /// easyui中的tree
    /// </summary>
    public class treegrid
    {
        /// <summary>
        /// 行数据集
        /// </summary>
        public dynamic rows;
    }
    /// <summary>
    /// 树形列表控件对应的对象
    /// </summary>
    public class SystemTree
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string id;
        /// <summary>
        /// 显示内容
        /// </summary>
        public string text;
        /// <summary>
        /// 图标
        /// </summary>
        public string iconCls;

        /// <summary>
        /// 根据需要存放数据
        /// </summary>
        public Dictionary<string,string> Custom;

        /// <summary>
        /// 是否被选中，checked为C#关键字，所以前面加@
        /// </summary>
        public bool @checked = false;
        /// <summary>
        /// 当前是展开还是收缩的状态
        /// </summary>
        public string state;
        /// <summary>
        /// 子节点集合
        /// </summary>
        /// 
        public TreeAtrribute attributes;
        /// <summary>
        /// 类别 by xubc 专用
        /// </summary>
        public List<SystemTree> children = new List<SystemTree>();
    }
    public class TreeAtrribute
    {
        /// <summary>
        /// 科目说明
        /// </summary>
        public string SubjectNote;
        /// <summary>
        /// 测算说明
        /// </summary>
        public string Remark;
        /// <summary>
        /// 标示是哪个数据库
        /// </summary>
        public Guid guid;
        public decimal? FixedFund;
        public int? AmountType;
       
    }
    /// <summary>
    /// 创建人赵斌斌，有问题找他
    /// </summary>
    public class NewSystemTree
    {
        /// <summary>
        /// 主键
        /// </summary>
        public Guid id;
        /// <summary>
        /// 显示内容
        /// </summary>
        public string text;
        /// <summary>
        /// 图标
        /// </summary>
        public string iconCls;
        /// <summary>
        /// 是否被选中，checked为C#关键字，所以前面加@
        /// </summary>
        public bool @checked = false;
        /// <summary>
        /// 当前是展开还是收缩的状态
        /// </summary>
        public string state;
        /// <summary>
        /// 子节点集合
        /// </summary>
        public List<NewSystemTree> children = new List<NewSystemTree>();
    }


    /// <summary>
    /// 列表中的按钮导航
    /// </summary>
    public class toolbar
    {
        /// <summary>
        /// 显示的文本
        /// </summary>
        public string text;
        /// <summary>
        /// 图标
        /// </summary>
        public string iconCls;
        /// <summary>
        /// 处理方法
        /// </summary>
        public string handler;
    }
}

