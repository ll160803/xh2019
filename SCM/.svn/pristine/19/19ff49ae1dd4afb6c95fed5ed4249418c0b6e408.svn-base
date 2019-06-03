using System;
using System.Collections.Generic;
using System.Text;
using Ipedf.Web.Entity;using Ipedf.Web.DataAccess;
using System.Data;
using Ipedf.Core;
using System.Text.RegularExpressions;
using ConstLibrary = Ipedf.Common;
using Ipedf.Common;
namespace Ipedf.Web.BizLogic
{

    public partial class SystemLogic
    {
        public  string PrepareCode(string settingName)
        {
            if (settingName == string.Empty)
                return Ipedf.Common.Template.CodeSettingRequestMsg;
            CauseObject_V_COM_QUERY_CODE p = new CauseObject_V_COM_QUERY_CODE();
            p.NAME = settingName;
            //临时处理,问题的重点在于SqlServer2000中Com_Data注册失败...
            p.DATA_ORGANISE_ID = SystemLogic.Proxy.CurrentUser == null ? string.Empty:SystemLogic.Proxy.CurrentUser.DATA_ORGANISE_ID;
            SystemLogic.Proxy.AuditQuery(p);
            DisplayObject_V_COM_QUERY_CODE[] results = HelperObject_V_COM_QUERY_CODE.Query(p);
            if (results.Length == 0)
                return Ipedf.Common.Template.CodeSettingRequestMsg;
            List<Segment> segments = new List<Segment>();
            foreach (DisplayObject_V_COM_QUERY_CODE result in results)
            {
                Segment segment = new Segment(result);
                segments.Add(segment);
            }
            string ret = PrepareCode(segments);
            List<EntityObject_COM_CODE_DETAIL> toUpdate = new List<EntityObject_COM_CODE_DETAIL>();
            //更新到数据库
            foreach (Segment segment in segments)
            {
                if (segment.编码类型 == 编码类型.变长序列 || segment.编码类型 == 编码类型.定长序列 || segment.编码类型 == 编码类型.按天更新定长序列)
                {
                    EntityObject_COM_CODE_DETAIL detail = new EntityObject_COM_CODE_DETAIL();
                    detail.BASE_ID = segment.BaseId;
                    detail.ID = segment.Id;
                    detail.CODE_INDEX = segment.Index;
                    detail.CODE_TYPE = (decimal)(int)segment.编码类型;
                    detail.CODE_VALUE = segment.Value;
                    detail.CODE_WIDTH = segment.Width;
                    toUpdate.Add(detail);
                }
            }
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (EntityObject_COM_CODE_DETAIL detail in toUpdate)
                        {
                            HelperObject_COM_CODE_DETAIL.Update(detail, transaction);
                        }
                        transaction.Commit();
                    }
                    catch (Exception expt)
                    {
                        transaction.Rollback();
                        throw expt;
                    }
                    finally
                    {
                        IDALProvider.IDAL.PushConnection(connection);
                    }
                }
            }
            return ret;
        }
        private string PrepareCode(List<Segment> segments)
        {
            StringBuilder ret = new StringBuilder();
            foreach (Segment segment in segments)
            {
                switch (segment.编码类型)
                {
                    case 编码类型.定长序列:
                        {
                            if (Regex.Match(segment.Value, @"^([0]+)").Success)
                            {
                                ret.Append(segment.Value);
                                //自增
                                string value = Regex.Replace(segment.Value, @"^([0]+)", string.Empty);
                                segment.Value = Convert.ToString(int.Parse(value) + 1).PadLeft((int)segment.Width, '0');
                            }
                            else
                            {
                                segment.Value = 1.ToString().PadLeft((int)segment.Width, '0');
                                ret.Append(segment.Value);
                                segment.Value = 2.ToString().PadLeft((int)segment.Width, '0');
                            }
                            break;
                        }
                    case 编码类型.按天更新定长序列:
                        {                            
                            if (Regex.Match(segment.Value, @"^([0]+)").Success)
                            {
                                //匹配当前日期
                                if (segment.Value.Split('/')[1] == System.DateTime.Now.ToString("yyyyMMdd"))
                                {
                                    ret.Append(segment.Value.Split('/')[0]);//截取非日期部分
                                    //自增
                                    string value = Regex.Replace(segment.Value.Split('/')[0], @"^([0]+)", string.Empty);//截取非日期部分
                                    segment.Value = string.Format("{0}/{1}", Convert.ToString(int.Parse(value) + 1).PadLeft((int)segment.Width, '0'), System.DateTime.Now.ToString("yyyyMMdd"));
                                }
                                else
                                {
                                    //生成新编码
                                    segment.Value = string.Format("{0}/{1}", 1.ToString().PadLeft((int)segment.Width, '0'), System.DateTime.Now.ToString("yyyyMMdd"));
                                    ret.Append(segment.Value.Split('/')[0]);//截取非日期部分
                                    segment.Value = string.Format("{0}/{1}", 2.ToString().PadLeft((int)segment.Width, '0'), System.DateTime.Now.ToString("yyyyMMdd"));
                                }
                            }                            
                            else
                            {
                                //生成新编码
                                segment.Value = string.Format("{0}/{1}", 1.ToString().PadLeft((int)segment.Width, '0'), System.DateTime.Now.ToString("yyyyMMdd"));
                                ret.Append(segment.Value.Split('/')[0]);//截取非日期部分
                                segment.Value = string.Format("{0}/{1}", 2.ToString().PadLeft((int)segment.Width, '0'), System.DateTime.Now.ToString("yyyyMMdd"));
                            }                           
                            break;
                        }
                    case 编码类型.固定内容:
                        {
                            ret.Append(segment.Value);
                            break;
                        }
                    case 编码类型.长整日期:
                        {
                            ret.Append(new LongDate().ToString());
                            break;
                        }
                    case 编码类型.短整日期:
                        {
                            ret.Append(new ShortDate().ToString());
                            break;
                        }
                    case 编码类型.分隔符号:
                        {
                            ret.Append(segment.Value);
                            break;
                        }
                    case 编码类型.变长序列:
                        {
                            if (Regex.Match(segment.Value, @"^([0-9]+)").Success)
                            {
                                ret.Append(segment.Value);
                                //自增
                                segment.Value = Convert.ToString(int.Parse(segment.Value) + 1);
                            }
                            else
                            {
                                segment.Value = 1.ToString();
                                ret.Append(segment.Value);
                                segment.Value = 2.ToString();
                            }
                            break;
                        }
                }
            }
            return ret.ToString();
        } 
        private class Segment
        {
            private string id;
            private string baseId;

            public string BaseId
            {
                get { return baseId; }
                set { baseId = value; }
            }
            public string Id
            {
                get { return id; }
            }
            private 编码类型 _编码类型;

            internal 编码类型 编码类型
            {
                get { return _编码类型; }

            }
            private decimal index;

            public decimal Index
            {
                get { return index; }

            }
            private decimal width;

            public decimal Width
            {
                get { return width; }

            }
            private string value;

            public string Value
            {
                get { return this.value; }
                set { this.value = value; }
            }
            public Segment(DisplayObject_V_COM_QUERY_CODE data)
            {
                this.index = data.CODE_INDEX;
                this.value = data.CODE_VALUE;
                this.width = data.CODE_WIDTH;
                this._编码类型 = (编码类型)Enum.Parse(typeof(编码类型),data.CODE_TYPE.ToString());
                this.id = data.CODE_ID;
                this.baseId = data.ID;
            }
        }
        private class ShortDate
        {
            public override string ToString()
            {
                StringBuilder ret = new StringBuilder();
                ret.Append(System.DateTime.Now.ToString("yyMMdd"));
                return ret.ToString();
            }
        }
        private class LongDate
        {
            public override string ToString()
            {
                StringBuilder ret = new StringBuilder();
                ret.Append(System.DateTime.Now.ToString("yyyyMMdd"));
                return ret.ToString();
            }
        }
    }
}
