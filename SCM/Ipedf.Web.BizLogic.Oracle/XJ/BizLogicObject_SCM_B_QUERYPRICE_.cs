
using System;
using System.Data;
using System.Linq;
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
namespace Ipedf.Web.BizLogic
{
    public partial class BizLogicObject_SCM_B_QUERYPRICE
    {
        //询价信息查询
        public DisplayObject_SCM_B_QUERYPRICE_I[] Query_I(CauseObject_SCM_B_QUERYPRICE cause)
        {
            if (LocalMode)
            {
                SystemLogic.Proxy.AuditQuery(cause);

                //平台自动生成代码
                return HelperObject_SCM_B_QUERYPRICE.Query_I(cause);
            }
            else
            {
                using (ServiceManager<ServiceContract_SCM_B_QUERYPRICE> smgr = new ServiceManager<ServiceContract_SCM_B_QUERYPRICE>(ServiceUri))
                {
                    return smgr.Service.Query_I(cause);
                }
            }
        }

        //询价信息查询分页
        public DisplayObject_SCM_B_QUERYPRICE_I[] Query_I(CauseObject_SCM_B_QUERYPRICE cause, PagingParamter paging, OrderByParameter order)
        {
            if (LocalMode)
            {
                SystemLogic.Proxy.AuditQuery(cause);

                //平台自动生成代码
                return HelperObject_SCM_B_QUERYPRICE.Query_I(cause, paging, order);
            }
            else
            {
                using (ServiceManager<ServiceContract_SCM_B_QUERYPRICE> smgr = new ServiceManager<ServiceContract_SCM_B_QUERYPRICE>(ServiceUri))
                {
                    return smgr.Service.Query_I(cause, paging, order);
                }
            }
        }

        /// <summary>
        /// 删除询价、供应商、指定厂家
        /// </summary>
        /// <param name="itemEntity">询价集合</param>
        /// <returns></returns>
        public BizLogicMsg DeletePost(EntityObject_SCM_B_QUERYPRICE[] itemEntity)
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
                            bool IsErr = false;
                            int nCount = 0;

                            CauseObject_SCM_B_QUERYPRICE cause = new CauseObject_SCM_B_QUERYPRICE();

                            foreach (EntityObject_SCM_B_QUERYPRICE entity in itemEntity)
                            {
                                cause.SetINValue("ID", entity.ID);
                            }
                            cause.QUERY_STATE = "SCM000101";
                            DisplayObject_SCM_B_QUERYPRICE[] itemDis = HelperObject_SCM_B_QUERYPRICE.Query(cause, transaction);

                            if (itemDis.Length > 0)
                            {
                                CauseObject_SCM_B_QUERYPRICE_D causeD = new CauseObject_SCM_B_QUERYPRICE_D();
                                CauseObject_SCM_B_QUERYPRICE_PRODUCT causeQp = new CauseObject_SCM_B_QUERYPRICE_PRODUCT();

                                foreach (EntityObject_SCM_B_QUERYPRICE entity in itemDis)
                                {
                                    causeD.SetINValue("BASE_ID", entity.ID);
                                    causeQp.SetINValue("BASE_ID", entity.ID);
                                }

                                int amount = 0;
                                DisplayObject_SCM_B_QUERYPRICE_D[] itemDisD = HelperObject_SCM_B_QUERYPRICE_D.Query(causeD, transaction);
                                if (itemDisD.Length > 0)
                                {
                                    amount = HelperObject_SCM_B_QUERYPRICE_D.Delete(causeD, transaction);
                                    if (amount == 0)
                                    {
                                        IsErr = true;
                                        msg.Message = "删除供应商数据失败!";
                                        msg.Succeed = false;
                                    }
                                    else
                                    {
                                        nCount += 1;
                                    }
                                }

                                if (!IsErr)
                                {
                                    DisplayObject_SCM_B_QUERYPRICE_PRODUCT[] itemDisQp = HelperObject_SCM_B_QUERYPRICE_PRODUCT.Query(causeQp, transaction);
                                    if (itemDisQp.Length > 0)
                                    {
                                        amount = HelperObject_SCM_B_QUERYPRICE_PRODUCT.Delete(causeQp, transaction);
                                        if (amount == 0)
                                        {
                                            IsErr = true;
                                            msg.Message = "删除指定厂商数据失败!";
                                            msg.Succeed = false;
                                        }
                                        else
                                        {
                                            nCount += 1;
                                        }
                                    }
                                }
                                if (!IsErr)
                                {
                                    if (itemDis.Length > 0)
                                    {
                                        amount = HelperObject_SCM_B_QUERYPRICE.Delete(cause, transaction);
                                        if (amount == 0)
                                        {
                                            IsErr = true;
                                            msg.Message = "删除询价数据失败!";
                                            msg.Succeed = false;
                                        }
                                        else
                                        {
                                            nCount += 1;
                                        }
                                    }
                                }
                            }

                            if (!IsErr && nCount > 0)
                            {
                                //平台自动生成代码
                                transaction.Commit();
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
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_SCM_B_QUERYPRICE> smgr = new ServiceManager<ServiceContract_SCM_B_QUERYPRICE>(ServiceUri))
                {
                    return smgr.Service.DeletePost(itemEntity);
                }
            }
        }

        public DisplayObject_SCM_B_QUERYPRICE_E[] Query_E(CauseObject_SCM_B_QUERYPRICE cause, PagingParamter paging, OrderByParameter order)
        {
            if (LocalMode)
            {
                SystemLogic.Proxy.AuditQuery(cause);

                DisplayObject_SCM_B_QUERYPRICE[] itemDis = HelperObject_SCM_B_QUERYPRICE.Query(cause, paging, order);
                DisplayObject_SCM_B_QUERYPRICE_E[] reDisplay = new DisplayObject_SCM_B_QUERYPRICE_E[itemDis.Length];

                if (itemDis.Length > 0)
                {
                    CauseObject_SCM_B_QUERYPRICE_PRODUCT causeQp = new CauseObject_SCM_B_QUERYPRICE_PRODUCT();
                    for (int i = 0; i < itemDis.Length; i++)
                    {
                        causeQp.SetINValue("BASE_ID", itemDis[i].ID);
                    }
                    DisplayObject_SCM_B_QUERYPRICE_PRODUCT[] itemQp = HelperObject_SCM_B_QUERYPRICE_PRODUCT.Query(causeQp);

                    DisplayObject_SCM_B_QUERYPRICE_PRODUCT[] itemQueryQp = null;
                    //平台自动生成代码
                    
                    for (int j = 0; j < itemDis.Length; j++)
                    {
                        DisplayObject_SCM_B_QUERYPRICE_E entity = getDisplayQueryPriceE(itemDis[0]);
                        itemQueryQp = itemQp.Where(p => p.BASE_ID == itemDis[0].ID).ToArray();
                        if (itemQueryQp.Length > 0)
                        {
                            entity.PRODUCT_NAME = itemQueryQp[0].PRODUCT_NAME;
                        }

                        reDisplay[j] = entity;
                    }
                }

                return reDisplay;
            }
            else
            {
                using (ServiceManager<ServiceContract_SCM_B_QUERYPRICE> smgr = new ServiceManager<ServiceContract_SCM_B_QUERYPRICE>(ServiceUri))
                {
                    return smgr.Service.Query_E(cause, paging, order);
                }
            }
        }

        /// <summary>
        /// 获取编辑询价和指定厂商
        /// </summary>
        /// <param name="cause"></param>
        /// <returns></returns>
        public DisplayObject_SCM_B_QUERYPRICE_E[] Query_E(CauseObject_SCM_B_QUERYPRICE cause)
        {
            if (LocalMode)
            {
                SystemLogic.Proxy.AuditQuery(cause);

                DisplayObject_SCM_B_QUERYPRICE[] itemDis = HelperObject_SCM_B_QUERYPRICE.Query(cause);
                DisplayObject_SCM_B_QUERYPRICE_E[] reDisplay = new DisplayObject_SCM_B_QUERYPRICE_E[itemDis.Length];

                if (itemDis.Length > 0)
                {
                    CauseObject_SCM_B_QUERYPRICE_PRODUCT causeQp = new CauseObject_SCM_B_QUERYPRICE_PRODUCT();
                    for (int i = 0; i < itemDis.Length; i++)
                    {
                        causeQp.SetINValue("BASE_ID", itemDis[i].ID);
                    }
                    DisplayObject_SCM_B_QUERYPRICE_PRODUCT[] itemQp = HelperObject_SCM_B_QUERYPRICE_PRODUCT.Query(causeQp);

                    DisplayObject_SCM_B_QUERYPRICE_PRODUCT[] itemQueryQp = null;
                    //平台自动生成代码
                    if (itemQp.Length > 0)
                    {
                        for (int j = 0; j < itemDis.Length; j++)
                        {
                            itemQueryQp = itemQp.Where(p => p.BASE_ID == itemDis[0].ID).ToArray();
                            DisplayObject_SCM_B_QUERYPRICE_E entity = getDisplayQueryPriceE(itemDis[0]);
                            if (itemQueryQp.Length > 0)
                            {
                                entity.PRODUCT_NAME = itemQueryQp[0].PRODUCT_NAME;
                            }

                            reDisplay[j] = entity;
                        }
                    }
                }

                return reDisplay;
            }
            else
            {
                using (ServiceManager<ServiceContract_SCM_B_QUERYPRICE> smgr = new ServiceManager<ServiceContract_SCM_B_QUERYPRICE>(ServiceUri))
                {
                    return smgr.Service.Query_E(cause);
                }
            }
        }

        /// <summary>
        /// 询价更新保存
        /// </summary>
        /// <param name="listEntity">询价更新保存数据</param>
        /// <param name="IsSubmit">是否提交</param>
        /// <param name="listIDs">返回IDs集合</param>
        /// <returns></returns>
        public BizLogicMsg UpdatePost(List<EntityObject_SCM_B_QUERYPRICE_U> listEntity, bool IsSubmit, List<DisplayObject_SCM_B_QUERYPRICE_E> resultDisplay)
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
                            int amount = 0;
                            bool IsErr = false;
                            bool IsTrue = true;
                            int nCount = 0;

                            DisplayObject_SCM_B_QUERYPRICE[] itemM = null;
                            nCount = listEntity.Where(p => !string.IsNullOrEmpty(p.ID)).Count();
                            if (nCount > 0)
                            {
                                CauseObject_SCM_B_QUERYPRICE causeM = new CauseObject_SCM_B_QUERYPRICE();

                                foreach (EntityObject_SCM_B_QUERYPRICE_U entityE in listEntity)
                                {
                                    if (!string.IsNullOrEmpty(entityE.ID))
                                    {
                                        causeM.SetINValue("ID", entityE.ID);
                                    }
                                }

                                itemM = HelperObject_SCM_B_QUERYPRICE.Query(causeM, transaction);
                                //删除明细数据
                                IsTrue = deleteQueryPriceDetail(itemM, transaction);
                            }
                            DateTime resultEndDate = Ipedf.Common.Template.UndefineDatetime;
                            if (IsTrue || nCount == 0)
                            {
                                CauseObject_COM_TYPE causeCt = new CauseObject_COM_TYPE();
                                causeCt.PARENT_ID = "SCM0001";
                                DisplayObject_COM_TYPE[] displayCtState = HelperObject_COM_TYPE.Query(causeCt, transaction);
                                causeCt.PARENT_ID = "SCM0002";
                                DisplayObject_COM_TYPE[] displayCtType = HelperObject_COM_TYPE.Query(causeCt, transaction);

                                foreach (EntityObject_SCM_B_QUERYPRICE_U entityE in listEntity)
                                {
                                    DateTime.TryParse(entityE.END_DATES, out resultEndDate);

                                    entityE.END_DATE = resultEndDate;
                                    EntityObject_SCM_B_QUERYPRICE entity = getEntityQueryPrice(entityE);

                                    if (!string.IsNullOrEmpty(entity.ID))
                                    {
                                        //获取询价类型
                                        DisplayObject_SCM_B_QUERYPRICE[] itemQueryM = itemM.Where(p => p.ID == entity.ID).ToArray();
                                        entity = getQueryPriceState(entity, IsSubmit, itemQueryM[0].QUERY_STATE);

                                        if (IsSubmit)
                                            entity.QUERY_DATE = DateTime.Now;

                                        entity.SetNotUpdate("CODE", "MATNR_ID", "DEPT_ID", "QUERY_TYPE", "ADJUSTPRICE_ID");
                                        SystemLogic.Proxy.AuditEdit(entity);
                                        amount = HelperObject_SCM_B_QUERYPRICE.Update(entity, transaction);
                                        if (amount > 0)
                                        {
                                            DisplayObject_SCM_B_QUERYPRICE_E resultE = getDisplayQueryPriceE(entity, itemQueryM[0].DEPT_ID_NAME, getQueryPriceStateName(displayCtState, entity), itemQueryM[0].QUERY_TYPE_NAME);

                                            IsErr = QueryPriceDetailAdd(entity, entityE.PRODUCT_NAME, entityE.QueryPriceDetailList, transaction);
                                            resultE.PRODUCT_NAME = entityE.PRODUCT_NAME;
                                            if (!IsErr)
                                            {
                                                resultDisplay.Add(resultE);
                                            }
                                        }
                                        else
                                        {
                                            IsErr = true;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        entity.QUERY_STATE = IsSubmit ? "SCM000102" : "SCM000101";
                                        entity.DEPT_ID = SystemLogic.Proxy.CurrentUser.DEPART_ID;
                                        if (IsSubmit)
                                        {
                                            entity.QUERY_DATE = DateTime.Now;
                                        }
                                        else
                                        {
                                            entity.QUERY_DATE = DateTime.Parse(entity.QUERY_DATE.ToString("yyyy-MM-dd")+" "+ string.Format("{0:T}",DateTime.Now));
                                        }
                                        SystemLogic.Proxy.AuditAdd(entity);
                                        amount = HelperObject_SCM_B_QUERYPRICE.Save_E(entity, transaction);
                                        if (amount > 0)
                                        {
                                            DisplayObject_SCM_B_QUERYPRICE_E resultE = getDisplayQueryPriceE(entity, SystemLogic.Proxy.CurrentUser.DEPART_ID_NAME, getQueryPriceStateName(displayCtState, entity), getQueryPriceStateName(displayCtType, entity));
                                            IsErr = QueryPriceDetailAdd(entity, entityE.PRODUCT_NAME, entityE.QueryPriceDetailList, transaction);
                                            resultE.PRODUCT_NAME = entityE.PRODUCT_NAME;
                                            if (!IsErr)
                                            {
                                                resultDisplay.Add(resultE);
                                            }
                                        }
                                        else
                                        {
                                            IsErr = true;
                                            break;
                                        }
                                    }
                                }
                                //平台自动生成代码
                                //PostSave(obj, transaction);
                            }
                            else
                            {
                                IsErr = true;
                            }


                            if (!IsErr)
                            {
                                transaction.Commit();
                            }
                            else
                            {
                                resultDisplay.Clear();
                                msg.Message = "更新数据失败!";
                                msg.Succeed = false;
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
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_SCM_B_QUERYPRICE> smgr = new ServiceManager<ServiceContract_SCM_B_QUERYPRICE>(ServiceUri))
                {
                    return smgr.Service.UpdatePost(listEntity, IsSubmit, resultDisplay);
                }
            }
        }

        //询价COM_TYPE询价状态得到NAME名称
        private string getQueryPriceStateName(DisplayObject_COM_TYPE[] displayCtState, EntityObject_SCM_B_QUERYPRICE entity)
        {
            string resultStr = "";
            if (!string.IsNullOrEmpty(entity.QUERY_STATE))
            {
                DisplayObject_COM_TYPE[] displayCtStateQuery = null;
                displayCtStateQuery = displayCtState.Where(c => c.ID.Trim() == entity.QUERY_STATE.Trim()).ToArray();
                if (displayCtStateQuery.Length > 0)
                {
                    resultStr = displayCtStateQuery[0].NAME;
                }
            }

            return resultStr;
        }

        //询价COM_TYPE询价类型得到NAME名称
        private string getQueryPriceTypeName(DisplayObject_COM_TYPE[] displayCtType, EntityObject_SCM_B_QUERYPRICE entity)
        {
            string resultStr = "";
            if (!string.IsNullOrEmpty(entity.QUERY_TYPE))
            {
                DisplayObject_COM_TYPE[] displayCtTypeQuery = null;
                displayCtTypeQuery = displayCtType.Where(c => c.ID.Trim() == entity.QUERY_TYPE.Trim()).ToArray();
                if (displayCtTypeQuery.Length > 0)
                {
                    resultStr = displayCtTypeQuery[0].NAME;
                }
            }
            return resultStr;

        }

        /// <summary>
        /// 批量更新询价状态
        /// </summary>
        /// <param name="date">撤销更新事件</param>
        /// <param name="itemIds">询价ID集合</param>
        /// <param name="type">状态类型</param>
        /// <returns></returns>
        public BizLogicMsg UpdateState(string date, string[] itemIds, int type)
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
                            bool IsTrue = true;
                            CauseObject_SCM_B_QUERYPRICE cause = new CauseObject_SCM_B_QUERYPRICE();
                            foreach (string Id in itemIds)
                            {
                                cause.SetINValue("ID", Id);
                            }
                            cause.SetCustomCondition(" AND SCM_B_QUERYPRICE.QUERY_STATE <> 'SCM000101'");
                            DisplayObject_SCM_B_QUERYPRICE[] itmeDisplay = HelperObject_SCM_B_QUERYPRICE.Query(cause, transaction);
                            string strError = "";
                            if (itmeDisplay.Length > 0)
                            {
                                int amount = 0;
                                CauseObject_SCM_B_QUERYPRICE_D caused = new CauseObject_SCM_B_QUERYPRICE_D();
                                foreach (DisplayObject_SCM_B_QUERYPRICE display in itmeDisplay)
                                {
                                    caused.SetINValue("BASE_ID", display.ID);
                                }
                                DisplayObject_SCM_B_QUERYPRICE_D[] itemDisd = HelperObject_SCM_B_QUERYPRICE_D.Query(caused,transaction);
                                if (itemDisd.Length>0)
                                {
                                    DisplayObject_SCM_B_QUERYPRICE_D[] itemDisdQuery = null;
                                    foreach (DisplayObject_SCM_B_QUERYPRICE display in itmeDisplay)
                                    {
                                        itemDisdQuery = itemDisd.Where(d => d.BASE_ID == display.ID).ToArray();
                                        if (itemDisdQuery.Length > 0)
                                        {
                                            EntityObject_SCM_B_QUERYPRICE obj = new EntityObject_SCM_B_QUERYPRICE();
                                            obj.ID = display.ID;
                                            if (type == 2)
                                            {
                                                obj.QUERY_STATE = "SCM000103";
                                                obj.SetUpdate("QUERY_STATE");
                                            }
                                            else
                                            {
                                                obj.QUERY_STATE = "SCM000102";
                                                obj.END_DATE = DateTime.Parse(date);
                                                obj.SetUpdate("QUERY_STATE", "END_DATE");
                                            }

                                            SystemLogic.Proxy.AuditEdit(obj);

                                            amount = HelperObject_SCM_B_QUERYPRICE.Update(obj, transaction);
                                            if (amount == 0)
                                            {
                                                IsTrue = false;
                                                break;
                                            }
                                            else
                                            {
                                                //平台自动生成代码
                                                PostSave(obj, transaction);
                                            }
                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(strError))
                                            {
                                                strError = display.TXZ01;
                                            }
                                            else
                                            {
                                                strError += "," + display.TXZ01;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    IsTrue = false;
                                    msg.Message = "选中更新的询价信息未填报供应商!";
                                }
                            }
                            else
                            {
                                IsTrue = false;
                            }

                            if (IsTrue && string.IsNullOrEmpty(strError))
                            {
                                transaction.Commit();
                            }
                            else
                            {
                                if (!string.IsNullOrEmpty(strError))
                                {
                                    throw new Exception("以下询价信息[" + strError + "]未填报供应商");
                                }
                                else
                                {
                                    msg.Succeed = false;
                                    if (string.IsNullOrEmpty(msg.Message))
                                        msg.Message = "更新状态失败!";
                                }
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
                    }
                }
                return msg;
            }
            else
            {
                using (ServiceManager<ServiceContract_SCM_B_QUERYPRICE> smgr = new ServiceManager<ServiceContract_SCM_B_QUERYPRICE>(ServiceUri))
                {
                    return smgr.Service.UpdateState(date, itemIds, type);
                }
            }
        }


        public DisplayObject_SCM_B_QUERYPRICE_E Get_U(DisplayObject_SCM_B_QUERYPRICE obj)
        {
            if (LocalMode)
            {

                //平台自动生成代码
                DisplayObject_SCM_B_QUERYPRICE display = HelperObject_SCM_B_QUERYPRICE.Get(obj);
                return getDisplayQueryPriceE(display);
            }
            else
            {
                using (ServiceManager<ServiceContract_SCM_B_QUERYPRICE> smgr = new ServiceManager<ServiceContract_SCM_B_QUERYPRICE>(ServiceUri))
                {
                    return smgr.Service.Get_U(obj);
                }
            }
        }

        //得到有效的询价状态
        private EntityObject_SCM_B_QUERYPRICE getQueryPriceState(EntityObject_SCM_B_QUERYPRICE entity, bool IsSubmit, string QUERY_STATE)
        {

            if (!string.IsNullOrEmpty(QUERY_STATE))
            {
                if (QUERY_STATE.Trim() == "SCM000103")
                {
                    entity.QUERY_STATE = "SCM000103";
                }
                else
                {
                    entity.QUERY_STATE = IsSubmit ? "SCM000102" : "SCM000101";
                }
            }
            else
            {
                entity.QUERY_STATE = IsSubmit ? "SCM000102" : "SCM000101";
            }
            return entity;
        }

        //删除询价明细(供应商、指定厂家)
        private bool deleteQueryPriceDetail(DisplayObject_SCM_B_QUERYPRICE[] itemM, IDbTransaction transaction)
        {
            int amount = 0;
            bool IsTrue = true;
            if (itemM.Length > 0)
            {
                CauseObject_SCM_B_QUERYPRICE_D cause = new CauseObject_SCM_B_QUERYPRICE_D();
                CauseObject_SCM_B_QUERYPRICE_PRODUCT causeQP = new CauseObject_SCM_B_QUERYPRICE_PRODUCT();

                foreach (DisplayObject_SCM_B_QUERYPRICE entity in itemM)
                {
                    cause.SetINValue("BASE_ID", entity.ID);
                    causeQP.SetINValue("BASE_ID", entity.ID);
                }

                DisplayObject_SCM_B_QUERYPRICE_D[] itemD = HelperObject_SCM_B_QUERYPRICE_D.Query(cause, transaction);
                DisplayObject_SCM_B_QUERYPRICE_PRODUCT[] itemQP = HelperObject_SCM_B_QUERYPRICE_PRODUCT.Query(causeQP, transaction);

                if (itemD.Length > 0)
                {
                    IsTrue = false;
                    amount = HelperObject_SCM_B_QUERYPRICE_D.Delete(cause, transaction);
                    if (amount > 0)
                    {
                        IsTrue = true;
                    }
                }

                if (itemQP.Length > 0)
                {
                    IsTrue = false;
                    amount = HelperObject_SCM_B_QUERYPRICE_PRODUCT.Delete(causeQP, transaction);
                    if (amount > 0)
                    {
                        IsTrue = true;
                    }
                }
            }

            return IsTrue;
        }

        //给原实体赋值
        private EntityObject_SCM_B_QUERYPRICE getEntityQueryPrice(EntityObject_SCM_B_QUERYPRICE_U entityU)
        {
            EntityObject_SCM_B_QUERYPRICE entity = new EntityObject_SCM_B_QUERYPRICE();
            entity.ID = entityU.ID;
            entity.CODE = entityU.CODE;
            entity.NAME = entityU.NAME;
            entity.MATNR = entityU.MATNR;
            entity.MATNR_ID = entityU.MATNR_ID;
            entity.MSEHT = entityU.MSEHT;
            entity.TXZ01 = entityU.TXZ01;
            entity.SPEC = entityU.SPEC;
            entity.AMOUNT = entityU.AMOUNT;
            entity.QUERY_DATE = entityU.QUERY_DATE;
            entity.END_DATE = entityU.END_DATE;
            entity.QUERY_STATE = entityU.QUERY_STATE;
            entity.QUERY_TYPE = entityU.QUERY_TYPE;
            entity.DEPT_ID = entityU.DEPT_ID;
            entity.COMMENTS = entityU.COMMENTS;
            entity.STATE = entityU.STATE;
            entity.ADJUSTPRICE_ID = entityU.ADJUSTPRICE_ID;
            return entity;
        }

        //编辑返回显示询价数据
        private DisplayObject_SCM_B_QUERYPRICE_E getDisplayQueryPriceE(DisplayObject_SCM_B_QUERYPRICE display)
        {
            DisplayObject_SCM_B_QUERYPRICE_E displayE = new DisplayObject_SCM_B_QUERYPRICE_E();
            if (display != null)
            {
                displayE.ID = display.ID;
                displayE.CODE = display.CODE;
                displayE.NAME = display.NAME;
                displayE.MATNR_ID = display.MATNR_ID;
                displayE.MATNR = display.MATNR;
                displayE.MSEHT = display.MSEHT;
                displayE.TXZ01 = display.TXZ01;
                displayE.SPEC = display.SPEC;
                displayE.DEPT_ID_NAME = display.DEPT_ID_NAME;
                displayE.DEPT_ID = display.DEPT_ID;
                displayE.AMOUNT = display.AMOUNT;
                displayE.QUERY_DATE = display.QUERY_DATE;
                displayE.END_DATE = display.END_DATE;
                displayE.QUERY_STATE = display.QUERY_STATE;
                displayE.QUERY_TYPE = display.QUERY_TYPE;
                displayE.QUERY_STATE_NAME = display.QUERY_STATE_NAME;
                displayE.QUERY_TYPE_NAME = display.QUERY_TYPE_NAME;
                displayE.COMMENTS = display.COMMENTS;
                displayE.STATE = display.STATE;
                displayE.STATE_NAME = display.STATE_NAME;
                displayE.ADJUSTPRICE_ID = display.ADJUSTPRICE_ID;

                if (displayE.QUERY_DATE != null && displayE.QUERY_DATE != Ipedf.Common.Template.UndefineDatetime)
                {
                    displayE.QUERY_DATES = displayE.QUERY_DATE.ToString("yyyy-MM-dd");
                }
                if (displayE.END_DATE != null && displayE.END_DATE != Ipedf.Common.Template.UndefineDatetime)
                {
                    displayE.END_DATES = displayE.END_DATE.ToString("yyyy-MM-dd");
                }
            }
            return displayE;
        }

        //保存后返回显示询价数据
        private DisplayObject_SCM_B_QUERYPRICE_E getDisplayQueryPriceE(EntityObject_SCM_B_QUERYPRICE entity, string DEPT_ID_NAME, string QUERY_STATE_NAME, string QUERY_TYPE_NAME)
        {
            DisplayObject_SCM_B_QUERYPRICE_E displayE = new DisplayObject_SCM_B_QUERYPRICE_E();
            displayE.ID = entity.ID;
            displayE.CODE = entity.CODE;
            displayE.NAME = entity.NAME;
            displayE.MATNR_ID = entity.MATNR_ID;
            displayE.MATNR = entity.MATNR;
            displayE.MSEHT = entity.MSEHT;
            displayE.TXZ01 = entity.TXZ01;
            displayE.SPEC = entity.SPEC;
            displayE.DEPT_ID_NAME = DEPT_ID_NAME;
            displayE.DEPT_ID = entity.DEPT_ID;
            displayE.AMOUNT = entity.AMOUNT;
            displayE.QUERY_DATE = entity.QUERY_DATE;
            displayE.END_DATE = entity.END_DATE;
            displayE.QUERY_STATE = entity.QUERY_STATE;
            displayE.QUERY_TYPE = entity.QUERY_TYPE;
            displayE.QUERY_STATE_NAME = QUERY_STATE_NAME;
            displayE.QUERY_TYPE_NAME = QUERY_TYPE_NAME;
            displayE.COMMENTS = entity.COMMENTS;
            displayE.ADJUSTPRICE_ID = entity.ADJUSTPRICE_ID;

            displayE.STATE = entity.STATE;
            if (displayE.QUERY_DATE != null && displayE.QUERY_DATE != Ipedf.Common.Template.UndefineDatetime)
            {
                displayE.QUERY_DATES = displayE.QUERY_DATE.ToString("yyyy-MM-dd");
            }
            if (displayE.END_DATE != null && displayE.END_DATE != Ipedf.Common.Template.UndefineDatetime)
            {
                displayE.END_DATES = displayE.END_DATE.ToString("yyyy-MM-dd");
            }
            //displayE.STATE_NAME = entity.STATE_NAME;
            return displayE;
        }

        //新增询价明细(供应商、指定厂家)
        private bool QueryPriceDetailAdd(EntityObject_SCM_B_QUERYPRICE entity, string PRODUCT_NAME, List<EntityObject_SCM_B_QUERYPRICE_D> ItemQueryPriceD, IDbTransaction transaction)
        {
            bool IsTrue = false;
            if (!string.IsNullOrEmpty(PRODUCT_NAME))
            {
                EntityObject_SCM_B_QUERYPRICE_PRODUCT entityQP = new EntityObject_SCM_B_QUERYPRICE_PRODUCT();
                entityQP.BASE_ID = entity.ID;
                entityQP.PRODUCT_NAME = PRODUCT_NAME;
                int amount = HelperObject_SCM_B_QUERYPRICE_PRODUCT.Save(entityQP, transaction);
                if (amount > 0)
                {
                    IsTrue = AddQueryPriceD(entity.ID, ItemQueryPriceD, transaction);
                }
                else
                {
                    IsTrue = true;
                }
            }else{
                IsTrue = AddQueryPriceD(entity.ID, ItemQueryPriceD, transaction);
            }
            return IsTrue;
        }

        //新增询价明细(供应商)
        private bool AddQueryPriceD(string ID, List<EntityObject_SCM_B_QUERYPRICE_D> ItemQueryPriceD, IDbTransaction transaction)
        {
            bool IsTrue = false;
            foreach (EntityObject_SCM_B_QUERYPRICE_D entity in ItemQueryPriceD)
            {
                entity.BASE_ID = ID;
                int amount = HelperObject_SCM_B_QUERYPRICE_D.Save(entity, transaction);
                if (amount == 0)
                {
                    IsTrue = true;
                    break;
                }
            }

            return IsTrue;
        }
    }
}
