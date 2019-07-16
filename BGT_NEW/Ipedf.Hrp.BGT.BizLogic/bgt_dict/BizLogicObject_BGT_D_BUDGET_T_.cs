#define NESTING
using System;
using System.Data;
using System.Collections;
using System.ServiceModel;
using Ipedf.Web.Entity;
using Ipedf.Web.DataAccess;
using Ipedf.Web.ServiceContract;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Web.BizLogic;
using Ipedf.Wcf.ClientProxy;
using System.Collections.Generic;
using System.Text;
using Ipedf.Common;
namespace Ipedf.Web.BizLogic
{

    public partial class BizLogicObject_BGT_D_BUDGET_T
    {
        /// <summary>
        /// 自动创建计算方式是历史数据*比例系数的科目的增比输入记录
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="transaction"></param>
        protected void CreateIncreaseScaleItemInputRecord(EntityObject_BGT_D_BUDGET_T entity, IDbTransaction transaction)
        {
            //检查明细表（BGT_D_BUDGET_T_D）中所有计算方法（CALCULATE_METHOD_ID）是历史数据*比例系数（00110003）的项目，复制到BGT_D_BUDGET_T_DEPT_I/BGT_D_BUDGET_T_CPN_I表，便于设置增长比例
            //先删除，再新增
            if (entity.TEMPLET_TYPE_ID.Trim() == "00090001") //单位
            {
                CauseObject_BGT_D_BUDGET_T_CPN_I pti = new CauseObject_BGT_D_BUDGET_T_CPN_I();
                pti.BASE_ID = entity.ID;
                HelperObject_BGT_D_BUDGET_T_CPN_I.Delete(pti, transaction);
            }
            else if (entity.TEMPLET_TYPE_ID.Trim() == "00090002")//科室
            {
                CauseObject_BGT_D_BUDGET_T_DEPT_I pti = new CauseObject_BGT_D_BUDGET_T_DEPT_I();
                pti.BASE_ID = entity.ID;
                HelperObject_BGT_D_BUDGET_T_DEPT_I.Delete(pti, transaction);
            }
            CauseObject_BGT_D_BUDGET_T_D ptd = new CauseObject_BGT_D_BUDGET_T_D();
            ptd.BASE_ID = entity.ID;
            ptd.CALCULATE_METHOD_ID = "00110003";//历史数据*比例系数
            EntityObject_BGT_D_BUDGET_T_D[] tds = HelperObject_BGT_D_BUDGET_T_D.Query(ptd, transaction);
            //查询所有有当前模板权限的预算科室
            CauseObject_BGT_D_BUDGET_T_A ta = new CauseObject_BGT_D_BUDGET_T_A();
            ta.BASE_ID = entity.ID;
            EntityObject_BGT_D_BUDGET_T_A[] depts = HelperObject_BGT_D_BUDGET_T_A.Query(ta);
            //生成单位/科室增比填写模板
            if (entity.TEMPLET_TYPE_ID.Trim() == "00090001") //单位
            {
                EntityObject_BGT_D_BUDGET_T_CPN_I ti = new EntityObject_BGT_D_BUDGET_T_CPN_I();
                ti.BASE_ID = entity.ID;
                ti.BUDGET_YEAR = entity.BUDGET_YEAR;
                ti.BUDGET_CONTENTS_ID = entity.BUDGET_CONTENTS_ID;
                HelperObject_BGT_D_BUDGET_T_CPN_I.Save(ti, transaction);
                foreach (EntityObject_BGT_D_BUDGET_T_D td in tds)
                {
                    EntityObject_BGT_D_BUDGET_T_CPN_I_D tid = new EntityObject_BGT_D_BUDGET_T_CPN_I_D();
                    tid.BASE_ID = ti.ID;
                    tid.BUDGET_YEAR_VALUE = 0;
                    tid.INCREASE_SCALE = 0;
                    tid.ITEM_ID = td.ITEM_ID;
                    HelperObject_BGT_D_BUDGET_T_CPN_I_D.Save(tid, transaction);
                }
            }
            else if (entity.TEMPLET_TYPE_ID.Trim() == "00090002")//科室
            {
                foreach (EntityObject_BGT_D_BUDGET_T_A dept in depts)
                {
                    EntityObject_BGT_D_BUDGET_T_DEPT_I ti = new EntityObject_BGT_D_BUDGET_T_DEPT_I();
                    ti.BASE_ID = entity.ID;
                    ti.BUDGET_DEPT_ID = dept.BUDGET_DEPT_ID;
                    ti.BUDGET_YEAR = entity.BUDGET_YEAR;
                    ti.BUDGET_CONTENTS_ID = entity.BUDGET_CONTENTS_ID;
                    HelperObject_BGT_D_BUDGET_T_DEPT_I.Save(ti, transaction);
                    foreach (EntityObject_BGT_D_BUDGET_T_D td in tds)
                    {
                        EntityObject_BGT_D_BUDGET_T_DEPT_I_D tid = new EntityObject_BGT_D_BUDGET_T_DEPT_I_D();
                        tid.BASE_ID = ti.ID;
                        tid.BUDGET_YEAR_VALUE = 0;
                        tid.INCREASE_SCALE = 0;
                        tid.ITEM_ID = td.ITEM_ID;
                        HelperObject_BGT_D_BUDGET_T_DEPT_I_D.Save(tid, transaction);
                    }
                }
            }
        }
        /// <summary>
        /// 自动创建年度分解月份输入记录
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="transaction"></param>
        protected void CreateYearResolveInputRecord(EntityObject_BGT_D_BUDGET_T entity, IDbTransaction transaction)
        {
            //先删除，再新增
            if (entity.TEMPLET_TYPE_ID.Trim() == "00090001") //单位
            {
                CauseObject_BGT_D_BUDGET_CPN_YEAR_R pyr = new CauseObject_BGT_D_BUDGET_CPN_YEAR_R();
                pyr.BUDGET_YEAR = entity.BUDGET_YEAR;
                HelperObject_BGT_D_BUDGET_CPN_YEAR_R.Delete(pyr, transaction);
            }
            else if (entity.TEMPLET_TYPE_ID.Trim() == "00090002")//科室
            {
                CauseObject_BGT_D_BUDGET_DEPT_YEAR_R pyr = new CauseObject_BGT_D_BUDGET_DEPT_YEAR_R();
                pyr.BUDGET_YEAR = entity.BUDGET_YEAR;
                HelperObject_BGT_D_BUDGET_DEPT_YEAR_R.Delete(pyr, transaction);
            }
            //取当前模板包含的科目
            CauseObject_BGT_D_BUDGET_T_D ptd = new CauseObject_BGT_D_BUDGET_T_D();
            ptd.BASE_ID = entity.ID;
            EntityObject_BGT_D_BUDGET_T_D[] tds = HelperObject_BGT_D_BUDGET_T_D.Query(ptd, transaction);
            //查询所有有当前模板权限的预算科室
            CauseObject_BGT_D_BUDGET_T_A ta = new CauseObject_BGT_D_BUDGET_T_A();
            ta.BASE_ID = entity.ID;
            EntityObject_BGT_D_BUDGET_T_A[] depts = HelperObject_BGT_D_BUDGET_T_A.Query(ta);
            //生成单位/科室分解填写模板
            if (entity.TEMPLET_TYPE_ID.Trim() == "00090001") //单位
            {
                EntityObject_BGT_D_BUDGET_CPN_YEAR_R yr = new EntityObject_BGT_D_BUDGET_CPN_YEAR_R();
                yr.BUDGET_YEAR = entity.BUDGET_YEAR;
                yr.BUDGET_CONTENTS_ID = entity.BUDGET_CONTENTS_ID;
                HelperObject_BGT_D_BUDGET_CPN_YEAR_R.Save(yr, transaction);
                foreach (EntityObject_BGT_D_BUDGET_T_D td in tds)
                {
                    EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I yri = new EntityObject_BGT_D_BUDGET_CPN_YEAR_R_I();
                    yri.BASE_ID = yr.ID;
                    yri.ITEM_ID = td.ITEM_ID;
                    HelperObject_BGT_D_BUDGET_CPN_YEAR_R_I.Save(yri, transaction);
                }
            }
            else if (entity.TEMPLET_TYPE_ID.Trim() == "00090002")//科室
            {
                foreach (EntityObject_BGT_D_BUDGET_T_A dept in depts)
                {
                    EntityObject_BGT_D_BUDGET_DEPT_YEAR_R yr = new EntityObject_BGT_D_BUDGET_DEPT_YEAR_R();
                    yr.BUDGET_DEPT_ID = dept.BUDGET_DEPT_ID;
                    yr.BUDGET_YEAR = entity.BUDGET_YEAR;
                    yr.BUDGET_CONTENTS_ID = entity.BUDGET_CONTENTS_ID;
                    HelperObject_BGT_D_BUDGET_DEPT_YEAR_R.Save(yr, transaction);
                    foreach (EntityObject_BGT_D_BUDGET_T_D td in tds)
                    {
                        EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I yri = new EntityObject_BGT_D_BUDGET_DEPT_YEAR_R_I();
                        yri.BASE_ID = yr.ID;
                        yri.ITEM_ID = td.ITEM_ID;
                        HelperObject_BGT_D_BUDGET_DEPT_YEAR_R_I.Save(yri, transaction);
                    }
                }
            }
        }
        public BizLogicMsg Calculate(EntityObject_BGT_D_BUDGET_T obj)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            CreateIncreaseScaleItemInputRecord(obj, transaction);
                            CreateYearResolveInputRecord(obj, transaction);
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_T> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T>(ServiceUri))
                {
                    return smgr.Service.Calculate(obj);
                }
            }
        }
        public override void PostSave(EntityObject_BGT_D_BUDGET_T entity, IDbTransaction transaction)
        {

        }
        public BizLogicMsg CommitSave(EntityObject_BGT_D_BUDGET_T saveBaseEntity, EntityObject_BGT_D_BUDGET_T_A[] saveDetailEntities)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            SystemLogic.Proxy.AuditAdd(saveBaseEntity);
                            HelperObject_BGT_D_BUDGET_T.Save(saveBaseEntity, transaction);
                            PostSave(saveBaseEntity, transaction);
                            foreach (EntityObject_BGT_D_BUDGET_T_A obj in saveDetailEntities)
                            {
                                obj.BASE_ID = saveBaseEntity.ID;
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_BGT_D_BUDGET_T_A.Save(obj, transaction);
                            }
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_T> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T>(ServiceUri))
                {
                    return smgr.Service.CommitSave(saveBaseEntity, saveDetailEntities);
                }
            }
        }
        public BizLogicMsg CommitUpdate(EntityObject_BGT_D_BUDGET_T updateBaseEntity, EntityObject_BGT_D_BUDGET_T_A[] saveDetailEntities, EntityObject_BGT_D_BUDGET_T_A[] updateDetailEntities, EntityObject_BGT_D_BUDGET_T_A[] deleteDetailEntities)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            SystemLogic.Proxy.AuditEdit(updateBaseEntity);
                            HelperObject_BGT_D_BUDGET_T.Update(updateBaseEntity, transaction);
                            PostSave(updateBaseEntity, transaction);
                            foreach (EntityObject_BGT_D_BUDGET_T_A obj in saveDetailEntities)
                            {
                                obj.BASE_ID = updateBaseEntity.ID;
                                SystemLogic.Proxy.AuditAdd(obj);
                                HelperObject_BGT_D_BUDGET_T_A.Save(obj, transaction);
                            }
                            foreach (EntityObject_BGT_D_BUDGET_T_A obj in updateDetailEntities)
                            {
                                SystemLogic.Proxy.AuditEdit(obj);
                                HelperObject_BGT_D_BUDGET_T_A.Update(obj, transaction);
                            }
                            foreach (EntityObject_BGT_D_BUDGET_T_A obj in deleteDetailEntities)
                            {
                                HelperObject_BGT_D_BUDGET_T_A.Delete(obj, transaction);
                            }
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_T> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T>(ServiceUri))
                {
                    return smgr.Service.CommitUpdate(updateBaseEntity, saveDetailEntities, updateDetailEntities, deleteDetailEntities);
                }
            }
        }
        public List<string> CheckPlanService(EntityObject_BGT_D_BUDGET_T obj, DataTable data)
        {
            if (LocalMode)
            {
                List<string> colMsg = null;
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            colMsg = CheckPlanImpl(obj, data, transaction);
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            colMsg = new List<string>();
                            colMsg.Add("Failed");
                            throw new Exception("读取数据失败, 请检查重试.");
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return colMsg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_T> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T>(ServiceUri))
                {
                    return smgr.Service.CheckPlanService(obj, data);
                }
            }
        }
        public BizLogicMsg ImportPlanService(EntityObject_BGT_D_BUDGET_T obj, DataTable data)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {

                        try
                        {
                            ImportPlanImpl(obj, data, transaction);
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_T> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T>(ServiceUri))
                {
                    return smgr.Service.ImportPlanService(obj, data);
                }
            }
        }
        private List<string> CheckPlanImpl(EntityObject_BGT_D_BUDGET_T obj, DataTable data, IDbTransaction transaction)
        {
            List<string> colMsg = new List<string>();              //批量保存每行数据保存结果, 用于回写到数据源文件, 且列表第一条数据作为数据源是否有错误的标识
            colMsg.Add("Succeed");
            int errNum = 0;      //记录每行数据的错误数量

            Dictionary<string, string> dicClt = new Dictionary<string, string>();       //保存计算方法缓存
            Dictionary<string, string> dicMethod = new Dictionary<string, string>();    //保存编制方法缓存

            CauseObject_COM_TYPE pClt = new CauseObject_COM_TYPE();
            pClt.PARENT_ID = "0011";
            EntityObject_COM_TYPE[] clts = HelperObject_COM_TYPE.Query(pClt, transaction);
            foreach (EntityObject_COM_TYPE clt in clts)
            {
                dicClt.Add(clt.NAME, clt.ID);
            }

            CauseObject_COM_TYPE pMethod = new CauseObject_COM_TYPE();
            pMethod.PARENT_ID = "0010";
            EntityObject_COM_TYPE[] methods = HelperObject_COM_TYPE.Query(pMethod, transaction);
            foreach (EntityObject_COM_TYPE method in methods)
            {
                dicMethod.Add(method.NAME, method.ID);
            }

            for (int i = 0; i < data.Rows.Count; i++)
            {
                StringBuilder strResult = new StringBuilder();              //保存每行数据检测结果
                strResult.Append("第" + (i + 1) + "行:");
                DataRow dataRow = data.Rows[i];

                //检测第一列数据 计划指标
                if (dataRow[0] == null || string.IsNullOrEmpty(dataRow[0].ToString().Trim()))
                {
                    strResult.Append("预算项目未填写");
                    errNum++;
                }
                else
                {
                    string itemName = dataRow[0].ToString().Trim();
                    CauseObject_BGT_D_PLAN_ITEM pItem = new CauseObject_BGT_D_PLAN_ITEM();
                    pItem.NAME = itemName;
                    pItem.BUDGET_YEAR = obj.BUDGET_YEAR;
                    pItem.IS_DISABLE = (decimal)Ipedf.Common.是否状态.否;
                    EntityObject_BGT_D_PLAN_ITEM[] items = HelperObject_BGT_D_PLAN_ITEM.Query(pItem, transaction);
                    if (items == null || items.Length == 0)        //需要在预算项目表做预算年度与预算项目名称唯一约束保证查询结果无数据或只有一条数据
                    {
                        strResult.Append("预算项目不存在 ");
                        errNum++;
                    }
                }
                //检测第三列数据 计算方法
                if (dataRow[2] == null || string.IsNullOrEmpty(dataRow[2].ToString().Trim()))
                {
                    strResult.Append("计算方法未填写");
                    errNum++;
                }
                else
                {
                    string itemName = dataRow[2].ToString().Trim();
                    if (!dicClt.ContainsKey(itemName))
                    {
                        strResult.Append("计算方法不存在");
                        errNum++;
                    }
                }
                //检测第五列数据 计算序
                decimal res = 0;
                if (!decimal.TryParse((dataRow[4] == null || string.IsNullOrEmpty(dataRow[4].ToString().Trim())) ? "0" : dataRow[4].ToString().Trim(), out res))
                {
                    strResult.Append("计算序有误 ");
                    errNum++;
                }
                //检测第六列数据 编制方法
                if (dataRow[5] == null || string.IsNullOrEmpty(dataRow[5].ToString().Trim()))
                {
                    strResult.Append("编制方法未填写");
                    errNum++;
                }
                else
                {
                    string itemName = dataRow[5].ToString().Trim();
                    if (!dicMethod.ContainsKey(itemName))
                    {
                        strResult.Append("编制方法不存在");
                        errNum++;
                    }
                }
                //汇总结果
                if (errNum != 0)
                {
                    colMsg[0] = "Failed";
                    colMsg.Add(strResult.ToString());
                    errNum = 0;
                }
            }
            return colMsg;
        }
        private void ImportPlanImpl(EntityObject_BGT_D_BUDGET_T obj, DataTable data, IDbTransaction transaction)
        {
            Dictionary<string, string> dicClt = new Dictionary<string, string>();       //保存计算方法缓存
            Dictionary<string, string> dicMethod = new Dictionary<string, string>();    //保存编制方法缓存

            CauseObject_COM_TYPE pClt = new CauseObject_COM_TYPE();
            pClt.PARENT_ID = "0011";
            EntityObject_COM_TYPE[] clts = HelperObject_COM_TYPE.Query(pClt, transaction);
            foreach (EntityObject_COM_TYPE clt in clts)
            {
                dicClt.Add(clt.NAME, clt.ID);
            }

            CauseObject_COM_TYPE pMethod = new CauseObject_COM_TYPE();
            pMethod.PARENT_ID = "0010";
            EntityObject_COM_TYPE[] methods = HelperObject_COM_TYPE.Query(pMethod, transaction);
            foreach (EntityObject_COM_TYPE method in methods)
            {
                dicMethod.Add(method.NAME, method.ID);
            }
            for (int i = 0; i < data.Rows.Count; i++)
            {
                EntityObject_BGT_D_BUDGET_T_D bgtD = new EntityObject_BGT_D_BUDGET_T_D();
                SystemLogic.Proxy.AuditAdd(bgtD);
                bgtD.BASE_ID = obj.ID;
                CauseObject_BGT_D_PLAN_ITEM pItem = new CauseObject_BGT_D_PLAN_ITEM();
                pItem.BUDGET_YEAR = obj.BUDGET_YEAR;
                pItem.NAME = data.Rows[i][0].ToString().Trim();
                pItem.IS_DISABLE = (decimal)Ipedf.Common.是否状态.否;
                EntityObject_BGT_D_PLAN_ITEM[] items = HelperObject_BGT_D_PLAN_ITEM.Query(pItem, transaction);
                bgtD.ITEM_ID = items[0].ID;
                bgtD.CONSULT = data.Rows[i][1].ToString().Trim(); ;
                bgtD.CALCULATE_METHOD_ID = dicClt[data.Rows[i][2].ToString().Trim()];
                bgtD.CALCULATE_FORMULA = data.Rows[i][3].ToString().Trim();
                bgtD.CALCULATE_INDEX = ResolveDataCellNumber(data.Rows[i][4]);
                bgtD.PREPARE_METHOD_ID = dicMethod[data.Rows[i][5].ToString().Trim()];
                HelperObject_BGT_D_BUDGET_T_D.Save(bgtD, transaction);
            }
        }
        public List<string> CheckIncomeService(EntityObject_BGT_D_BUDGET_T obj, DataTable data)
        {
            if (LocalMode)
            {
                List<string> colMsg = null;
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            colMsg = CheckIncomeImpl(obj, data, transaction);
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            colMsg = new List<string>();
                            colMsg.Add("Failed");
                            throw new Exception("读取数据失败, 请检查重试.");
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return colMsg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_T> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T>(ServiceUri))
                {
                    return smgr.Service.CheckIncomeService(obj, data);
                }
            }
        }
        public BizLogicMsg ImportIncomeService(EntityObject_BGT_D_BUDGET_T obj, DataTable data)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {

                        try
                        {
                            ImportIncomeImpl(obj, data, transaction);
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_T> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T>(ServiceUri))
                {
                    return smgr.Service.ImportIncomeService(obj, data);
                }
            }
        }
        private List<string> CheckIncomeImpl(EntityObject_BGT_D_BUDGET_T obj, DataTable data, IDbTransaction transaction)
        {
            List<string> colMsg = new List<string>();              //批量保存每行数据保存结果, 用于回写到数据源文件, 且列表第一条数据作为数据源是否有错误的标识
            colMsg.Add("Succeed");
            int errNum = 0;      //记录每行数据的错误数量

            Dictionary<string, string> dicClt = new Dictionary<string, string>();       //保存计算方法缓存
            Dictionary<string, string> dicMethod = new Dictionary<string, string>();    //保存编制方法缓存

            CauseObject_COM_TYPE pClt = new CauseObject_COM_TYPE();
            pClt.PARENT_ID = "0011";
            EntityObject_COM_TYPE[] clts = HelperObject_COM_TYPE.Query(pClt, transaction);
            foreach (EntityObject_COM_TYPE clt in clts)
            {
                dicClt.Add(clt.NAME, clt.ID);
            }

            CauseObject_COM_TYPE pMethod = new CauseObject_COM_TYPE();
            pMethod.PARENT_ID = "0010";
            EntityObject_COM_TYPE[] methods = HelperObject_COM_TYPE.Query(pMethod, transaction);
            foreach (EntityObject_COM_TYPE method in methods)
            {
                dicMethod.Add(method.NAME, method.ID);
            }

            for (int i = 0; i < data.Rows.Count; i++)
            {
                StringBuilder strResult = new StringBuilder();              //保存每行数据检测结果
                strResult.Append("第" + (i + 1) + "行:");
                DataRow dataRow = data.Rows[i];

                //检测第一列数据 收入科目
                if (dataRow[0] == null || string.IsNullOrEmpty(dataRow[0].ToString().Trim()))
                {
                    strResult.Append("预算科目未填写");
                    errNum++;
                }
                else
                {
                    string itemName = dataRow[0].ToString().Trim();
                    CauseObject_BGT_D_BUDGET_ITEM pItem = new CauseObject_BGT_D_BUDGET_ITEM();
                    pItem.NAME = itemName;
                    pItem.ITEM_TYPE_ID = "00180004";//收入类型
                    pItem.BUDGET_YEAR = obj.BUDGET_YEAR;
                    pItem.IS_END = (decimal)是否状态.是;
                    EntityObject_BGT_D_BUDGET_ITEM[] items = HelperObject_BGT_D_BUDGET_ITEM.Query(pItem, transaction);
                    if (items == null || items.Length == 0)        //需要在预算项目表做预算年度与预算项目名称唯一约束保证查询结果无数据或只有一条数据
                    {
                        strResult.Append("收入科目不存在 ");
                        errNum++;
                    }
                }
                //检测第三列数据 计算方法
                if (dataRow[2] == null || string.IsNullOrEmpty(dataRow[2].ToString().Trim()))
                {
                    strResult.Append("计算方法未填写");
                    errNum++;
                }
                else
                {
                    string itemName = dataRow[2].ToString().Trim();
                    if (!dicClt.ContainsKey(itemName))
                    {
                        strResult.Append("计算方法不存在");
                        errNum++;
                    }
                }
                //检测第五列数据 计算序
                decimal res = 0;
                if (!decimal.TryParse((dataRow[4] == null || string.IsNullOrEmpty(dataRow[4].ToString().Trim())) ? "0" : dataRow[4].ToString().Trim(), out res))
                {
                    strResult.Append("计算序有误 ");
                    errNum++;
                }
                //检测第六列数据 编制方法
                if (dataRow[5] == null || string.IsNullOrEmpty(dataRow[5].ToString().Trim()))
                {
                    strResult.Append("编制方法未填写");
                    errNum++;
                }
                else
                {
                    string itemName = dataRow[5].ToString().Trim();
                    if (!dicMethod.ContainsKey(itemName))
                    {
                        strResult.Append("编制方法不存在");
                        errNum++;
                    }
                }
                //汇总结果
                if (errNum != 0)
                {
                    colMsg[0] = "Failed";
                    colMsg.Add(strResult.ToString());
                    errNum = 0;
                }
            }
            return colMsg;
        }
        private void ImportIncomeImpl(EntityObject_BGT_D_BUDGET_T obj, DataTable data, IDbTransaction transaction)
        {
            Dictionary<string, string> dicClt = new Dictionary<string, string>();       //保存计算方法缓存
            Dictionary<string, string> dicMethod = new Dictionary<string, string>();    //保存编制方法缓存

            CauseObject_COM_TYPE pClt = new CauseObject_COM_TYPE();
            pClt.PARENT_ID = "0011";
            EntityObject_COM_TYPE[] clts = HelperObject_COM_TYPE.Query(pClt, transaction);
            foreach (EntityObject_COM_TYPE clt in clts)
            {
                dicClt.Add(clt.NAME, clt.ID);
            }

            CauseObject_COM_TYPE pMethod = new CauseObject_COM_TYPE();
            pMethod.PARENT_ID = "0010";
            EntityObject_COM_TYPE[] methods = HelperObject_COM_TYPE.Query(pMethod, transaction);
            foreach (EntityObject_COM_TYPE method in methods)
            {
                dicMethod.Add(method.NAME, method.ID);
            }
            for (int i = 0; i < data.Rows.Count; i++)
            {
                EntityObject_BGT_D_BUDGET_T_D bgtD = new EntityObject_BGT_D_BUDGET_T_D();
                SystemLogic.Proxy.AuditAdd(bgtD);
                bgtD.BASE_ID = obj.ID;
                CauseObject_BGT_D_BUDGET_ITEM pItem = new CauseObject_BGT_D_BUDGET_ITEM();
                pItem.NAME = data.Rows[i][0].ToString().Trim(); ;
                pItem.ITEM_TYPE_ID = "00180004";//收入类型
                pItem.BUDGET_YEAR = obj.BUDGET_YEAR;
                pItem.IS_END = (decimal)是否状态.是;
                EntityObject_BGT_D_BUDGET_ITEM[] items = HelperObject_BGT_D_BUDGET_ITEM.Query(pItem, transaction);
                bgtD.ITEM_ID = items[0].ID;
                bgtD.CONSULT = data.Rows[i][1].ToString().Trim();
                bgtD.CALCULATE_METHOD_ID = dicClt[data.Rows[i][2].ToString().Trim()];
                bgtD.CALCULATE_FORMULA = data.Rows[i][3].ToString().Trim();
                bgtD.CALCULATE_INDEX = ResolveDataCellNumber(data.Rows[i][4]);
                bgtD.PREPARE_METHOD_ID = dicMethod[data.Rows[i][5].ToString().Trim()];
                HelperObject_BGT_D_BUDGET_T_D.Save(bgtD, transaction);
            }
        }
        public List<string> CheckPayService(EntityObject_BGT_D_BUDGET_T obj, DataTable data)
        {
            if (LocalMode)
            {
                List<string> colMsg = null;
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            colMsg = CheckPayImpl(obj, data, transaction);
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            colMsg = new List<string>();
                            colMsg.Add("Failed");
                            throw new Exception("读取数据失败, 请检查重试.");
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return colMsg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_T> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T>(ServiceUri))
                {
                    return smgr.Service.CheckPayService(obj, data);
                }
            }
        }
        public BizLogicMsg ImportPayService(EntityObject_BGT_D_BUDGET_T obj, DataTable data)
        {
            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {

                        try
                        {
                            ImportPayImpl(obj, data, transaction);
                            transaction.Commit();
                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_T> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T>(ServiceUri))
                {
                    return smgr.Service.ImportPayService(obj, data);
                }
            }
        }
        private List<string> CheckPayImpl(EntityObject_BGT_D_BUDGET_T obj, DataTable data, IDbTransaction transaction)
        {
            List<string> colMsg = new List<string>();              //批量保存每行数据保存结果, 用于回写到数据源文件, 且列表第一条数据作为数据源是否有错误的标识
            colMsg.Add("Succeed");
            int errNum = 0;      //记录每行数据的错误数量

            Dictionary<string, string> dicClt = new Dictionary<string, string>();       //保存计算方法缓存
            Dictionary<string, string> dicMethod = new Dictionary<string, string>();    //保存编制方法缓存

            CauseObject_COM_TYPE pClt = new CauseObject_COM_TYPE();
            pClt.PARENT_ID = "0011";
            EntityObject_COM_TYPE[] clts = HelperObject_COM_TYPE.Query(pClt, transaction);
            foreach (EntityObject_COM_TYPE clt in clts)
            {
                dicClt.Add(clt.NAME, clt.ID);
            }

            CauseObject_COM_TYPE pMethod = new CauseObject_COM_TYPE();
            pMethod.PARENT_ID = "0010";
            EntityObject_COM_TYPE[] methods = HelperObject_COM_TYPE.Query(pMethod, transaction);
            foreach (EntityObject_COM_TYPE method in methods)
            {
                dicMethod.Add(method.NAME, method.ID);
            }

            for (int i = 0; i < data.Rows.Count; i++)
            {
                StringBuilder strResult = new StringBuilder();              //保存每行数据检测结果
                strResult.Append("第" + (i + 1) + "行:");
                DataRow dataRow = data.Rows[i];

                //检测第一列数据 支出科目
                if (dataRow[0] == null || string.IsNullOrEmpty(dataRow[0].ToString().Trim()))
                {
                    strResult.Append("支出科目未填写");
                    errNum++;
                }
                else
                {
                    string itemName = dataRow[0].ToString().Trim();
                    CauseObject_BGT_D_BUDGET_ITEM pItem = new CauseObject_BGT_D_BUDGET_ITEM();
                    pItem.NAME = itemName;
                    pItem.ITEM_TYPE_ID = "00180005";//收入类型
                    pItem.BUDGET_YEAR = obj.BUDGET_YEAR;
                    pItem.IS_END = (decimal)是否状态.是;
                    EntityObject_BGT_D_BUDGET_ITEM[] items = HelperObject_BGT_D_BUDGET_ITEM.Query(pItem, transaction);
                    if (items == null || items.Length == 0)        //需要在预算项目表做预算年度与预算项目名称唯一约束保证查询结果无数据或只有一条数据
                    {
                        strResult.Append("支出科目不存在 ");
                        errNum++;
                    }
                }
                //检测第三列数据 计算方法
                if (dataRow[2] == null || string.IsNullOrEmpty(dataRow[2].ToString().Trim()))
                {
                    strResult.Append("计算方法未填写");
                    errNum++;
                }
                else
                {
                    string itemName = dataRow[2].ToString().Trim();
                    if (!dicClt.ContainsKey(itemName))
                    {
                        strResult.Append("计算方法不存在");
                        errNum++;
                    }
                }
                //检测第五列数据 计算序
                decimal res = 0;
                if (!decimal.TryParse((dataRow[4] == null || string.IsNullOrEmpty(dataRow[4].ToString().Trim())) ? "0" : dataRow[4].ToString().Trim(), out res))
                {
                    strResult.Append("计算序有误 ");
                    errNum++;
                }
                //检测第六列数据 编制方法
                if (dataRow[5] == null || string.IsNullOrEmpty(dataRow[5].ToString().Trim()))
                {
                    strResult.Append("编制方法未填写");
                    errNum++;
                }
                else
                {
                    string itemName = dataRow[5].ToString().Trim();
                    if (!dicMethod.ContainsKey(itemName))
                    {
                        strResult.Append("编制方法不存在");
                        errNum++;
                    }
                }
                //汇总结果
                if (errNum != 0)
                {
                    colMsg[0] = "Failed";
                    colMsg.Add(strResult.ToString());
                    errNum = 0;
                }
            }
            return colMsg;
        }
        private void ImportPayImpl(EntityObject_BGT_D_BUDGET_T obj, DataTable data, IDbTransaction transaction)
        {
            Dictionary<string, string> dicClt = new Dictionary<string, string>();       //保存计算方法缓存
            Dictionary<string, string> dicMethod = new Dictionary<string, string>();    //保存编制方法缓存

            CauseObject_COM_TYPE pClt = new CauseObject_COM_TYPE();
            pClt.PARENT_ID = "0011";
            EntityObject_COM_TYPE[] clts = HelperObject_COM_TYPE.Query(pClt, transaction);
            foreach (EntityObject_COM_TYPE clt in clts)
            {
                dicClt.Add(clt.NAME, clt.ID);
            }

            CauseObject_COM_TYPE pMethod = new CauseObject_COM_TYPE();
            pMethod.PARENT_ID = "0010";
            EntityObject_COM_TYPE[] methods = HelperObject_COM_TYPE.Query(pMethod, transaction);
            foreach (EntityObject_COM_TYPE method in methods)
            {
                dicMethod.Add(method.NAME, method.ID);
            }
            for (int i = 0; i < data.Rows.Count; i++)
            {
                EntityObject_BGT_D_BUDGET_T_D bgtD = new EntityObject_BGT_D_BUDGET_T_D();
                SystemLogic.Proxy.AuditAdd(bgtD);
                bgtD.BASE_ID = obj.ID;
                CauseObject_BGT_D_BUDGET_ITEM pItem = new CauseObject_BGT_D_BUDGET_ITEM();
                pItem.NAME = data.Rows[i][0].ToString().Trim(); ;
                pItem.ITEM_TYPE_ID = "00180005";//收入类型
                pItem.BUDGET_YEAR = obj.BUDGET_YEAR;
                pItem.IS_END = (decimal)是否状态.是;
                EntityObject_BGT_D_BUDGET_ITEM[] items = HelperObject_BGT_D_BUDGET_ITEM.Query(pItem, transaction);
                bgtD.ITEM_ID = items[0].ID;
                bgtD.CONSULT = data.Rows[i][1].ToString().Trim(); ;
                bgtD.CALCULATE_METHOD_ID = dicClt[data.Rows[i][2].ToString().Trim()];
                bgtD.CALCULATE_FORMULA = data.Rows[i][3].ToString().Trim();
                bgtD.CALCULATE_INDEX = ResolveDataCellNumber(data.Rows[i][4]);
                bgtD.PREPARE_METHOD_ID = dicMethod[data.Rows[i][5].ToString().Trim()];
                HelperObject_BGT_D_BUDGET_T_D.Save(bgtD, transaction);
            }
        }
        private decimal ResolveDataCellNumber(object dataCell)
        {
            return decimal.Parse((dataCell == null || string.IsNullOrEmpty(dataCell.ToString().Trim())) ? "0" : dataCell.ToString().Trim());
        }

        public BizLogicMsg CopyNew(EntityObject_BGT_D_BUDGET_T entity2)
        {

            if (LocalMode)
            {
                BizLogicMsg msg = new BizLogicMsg();
                using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            var entity = HelperObject_BGT_D_BUDGET_T.Get(entity2);
                            CauseObject_COM_TYPE pType = new CauseObject_COM_TYPE();
                            pType.PARENT_ID = "0009";
                            pType.SetCustomCondition(" and COM_TYPE.ID <>'" + entity.TEMPLET_TYPE_ID + "'");
                            var arrList = HelperObject_COM_TYPE.Query(pType);
                            var type_ID = "";
                            if (arrList.Length > 0)
                            {
                                type_ID = arrList[0].ID;
                                HelperObject_BGT_D_BUDGET_T.Save(new EntityObject_BGT_D_BUDGET_T { ID = Guid.NewGuid().ToString(), CODE=entity.CODE, BUDGET_CONTENTS_ID=entity.BUDGET_CONTENTS_ID ,COMMENTS=entity.COMMENTS,NAME = entity.NAME, BUDGET_YEAR = entity.BUDGET_YEAR, TEMPLET_TYPE_ID = type_ID }, transaction);
                                transaction.Commit();
                                msg = new BizLogicMsg(true, "复制成功");
                            }
                            else
                            {
                                msg = new BizLogicMsg(false, "模板分类不存在");
                            }

                        }
                        catch (Exception expt)
                        {
                            transaction.Rollback();
                            msg = new BizLogicMsg(false, expt.Message);
                            Error(expt);
                        }
                        finally
                        {
                            IDALProvider.IDAL.PushConnection(connection);
                        }
                        return msg;
                    }
                }
            }
            else
            {
                using (ServiceManager<ServiceContract_BGT_D_BUDGET_T> smgr = new ServiceManager<ServiceContract_BGT_D_BUDGET_T>(ServiceUri))
                {
                    return smgr.Service.CopyNew(entity2);
                }
            }
        }
    }
}
