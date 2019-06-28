using System;
using System.Data;
using System.Collections;
using Ipedf.Web.Entity;
using Ipedf.Web.DataAccess;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Web.BizLogic;
using Ipedf.Wcf.ClientProxy;
using Ipedf.Web.ServiceContract;
namespace Ipedf.Web.BizLogic
{
    public partial class BizLogicObject_COM_USER_FORM
    {
        public BizLogicMsg CreateUserFormByMenus(EntityObject_V_COM_QUERY_MENUS[] menus)
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
                            CauseObject_COM_FORM pForm = new CauseObject_COM_FORM();
                            foreach (EntityObject_V_COM_QUERY_MENUS menu in menus)
                            {
                                pForm.SetINValue("ID", menu.PAGE_ID);
                            }
                            DisplayObject_COM_FORM[] loadedForms = HelperObject_COM_FORM.Query(pForm, transaction);
                            foreach (EntityObject_COM_FORM form in loadedForms)
                            {
                                EntityObject_COM_USER_FORM uf = new EntityObject_COM_USER_FORM();
                                uf.USER_ID = SystemLogic.Proxy.CurrentUser.ID;
                                uf.FORM_ID = form.ID;
                                uf.DISPLAY_INDEX = 0;
                                HelperObject_COM_USER_FORM.Save(uf, transaction);
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
                using (ServiceManager<ServiceContract_COM_USER_FORM> smgr = new ServiceManager<ServiceContract_COM_USER_FORM>(ServiceUri))
                {
                    return smgr.Service.CreateUserFormByMenus(menus);
                }
            }
        }
        public EntityObject_COM_USER_FORM Load(string id, out EntityObject_COM_FORM form)
        {
            EntityObject_COM_USER_FORM uf = new EntityObject_COM_USER_FORM();
            form = new EntityObject_COM_FORM();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        uf.ID = id;
                        uf = HelperObject_COM_USER_FORM.Get(uf, transaction);
                        if (!string.IsNullOrEmpty(uf.FORM_ID))
                        {
                            form = new EntityObject_COM_FORM();
                            form.ID = uf.FORM_ID;
                            form = HelperObject_COM_FORM.Get(form, transaction);
                        }
                        transaction.Commit();
                    }
                    catch (Exception expt)
                    {
                        transaction.Rollback();
                        Error(expt);
                    }
                    finally
                    {
                        IDALProvider.IDAL.PushConnection(connection);
                    }
                }
            }
            return uf;
        }
    }
}
