using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ipedf.Hrp.BGT.Common
{
    [Serializable]
    public enum 控制阶段
    {
        开始申报 = 1,
        一上申报完成 = 2,
        二上申报开始 = 3,
        二上申报完成 = 4,
        开始执行 = 5
    }

    [Serializable]
    public enum 经费编辑
    {
        不可编辑 = 1,
        可编辑 = 2
    }
    [Serializable]
    public enum 预算阶段
    {
        编制阶段 = 1,
        执行阶段 = 2,
        归档 = 3

    }
}
