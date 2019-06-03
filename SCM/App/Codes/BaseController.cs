using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using System.Web.Mvc;
using System.IO;
using System.Data;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using System.Collections;

using System.Text.RegularExpressions;
using Ipedf.Web.Entity;
using System.Text;
using Ipedf.Web.BizLogic;

namespace Models
{
    //[SupportFilter]//此处如果去掉注释，则全部继承BaseController的Controller，都将执行SupportFilter过滤
    public class BaseController : Controller
    {
        /// <summary>
        /// 获取当前登陆人的名称
        /// </summary>
        /// <returns></returns>
        [SupportFilter]
        public string GetCurrentPerson()
        {
            //Account account = GetCurrentAccount();
            if (SystemLogic.Proxy.CurrentUser!=null)
            {
                return SystemLogic.Proxy.CurrentUser.NAME;//获取登录人的姓名hsc 2014 07 01
            }
            return string.Empty;
        }
        public string GetCurrentID()
        {
            if (SystemLogic.Proxy.CurrentUser != null)
            {
                return SystemLogic.Proxy.CurrentUser.ACCOUNT;//获取登录人的姓名hsc 2014 07 01
            }
            return string.Empty;
        }
        public string GetUserID()
        {
            if (SystemLogic.Proxy.CurrentUser != null)
            {
                return SystemLogic.Proxy.CurrentUser.ID;//获取登录人的姓名hsc 2014 07 01
            }
            return string.Empty;
        }
        public string GetUserRoleName()
        {
            CauseObject_V_GETPERSON cause = new CauseObject_V_GETPERSON();
            cause.ACCOUNT = GetCurrentID();
            var List = BizLogicObject_V_GETPERSON.Proxy.Query(cause);
            if (List != null)
            {
                return List[0].ROLENAME;//获取登录人的姓名hsc 2014 07 01
            }
            return string.Empty;
        }
        ///// <summary>
        ///// 获取当前登陆人的账户信息
        ///// </summary>
        ///// <returns>账户信息</returns>
        //[SupportFilter]
        //public Account GetCurrentAccount()
        //{
        //    if (Session["account"] != null)
        //    {
        //        Account account = (Account)Session["account"];
        //        return account;
        //    }
        //    return null;
        //}
        ///// <summary>
        ///// 获取所有角色GUid,在某些审批流程 可能不需要角色和科目权限
        ///// </summary>
        ///// <returns></returns>
        //public List<Guid> GetAllRoles()
        //{
        //    ISysRoleBLL dbll = new SysRoleBLL();
        //    return dbll.GetAll().Select(p => p.Id).Distinct().ToList();
        //}
        //public List<Guid> GetChildGuid(Guid parentId)
        //{
        //    ISysDepartmentBLL dBll = new SysDepartmentBLL();
        //    var childDepartmentList = dBll.GetChildGuidByParentId(parentId);
        //    return childDepartmentList;
        //}
        ///// <summary>
        ///// 获取所有部门的ID
        ///// </summary>
        ///// <param name="PersonId"></param>
        ///// <returns></returns>
        //public List<Guid> GetAllDepartmentGuid(Guid PersonId)
        //{
        //    ISysDepartmentBLL dBll = new SysDepartmentBLL();
        //    //var qdlist = dBll.GetAllByPersonID(PersonId).OrderBy(o => o.Code).ToList();

        //    var sysDeptIdList = dBll.GetAllByPersonID(PersonId).OrderBy(o => o.Code).Select(m => m.Id).ToList();
        //    return sysDeptIdList;
        //}

        ///// <summary>
        ///// 获取所有部门的ＩＤ
        ///// </summary>
        ///// <param name="PersonId"></param>
        ///// <returns></returns>
        //public List<Guid> GetAllDepartmentID()
        //{
        //    ISysDepartmentBLL dBll = new SysDepartmentBLL();
        //    //var qdlist = dBll.GetAllByPersonID(PersonId).OrderBy(o => o.Code).ToList();

        //    var sysDeptIdList = dBll.GetAllMetadata(null).OrderBy(o => o.Code).Select(m => m.Id).ToList();
        //    return sysDeptIdList;
        //}
        ///// <summary>
        ///// 获取所有部门的名称
        ///// </summary>
        ///// <param name="PersonId"></param>
        ///// <returns></returns>
        //public List<string> GetAllDepartmentName(Guid PersonId)
        //{
        //    ISysDepartmentBLL dBll = new SysDepartmentBLL();
        //    //var qdlist = dBll.GetAllByPersonID(PersonId).OrderBy(o => o.Code).ToList();

        //    var sysDeptIdList = dBll.GetAllByPersonID(PersonId).OrderBy(o => o.Code).Select(m => m.Name).ToList();
        //    return sysDeptIdList;
        //}
        ///// <summary>
        ///// 获取当前登录人员信息和单位信息公共方法
        ///// </summary>
        ///// <returns></returns>
        //[SupportFilter]
        //public SysPerson GetCurrentPersonObj()
        //{
        //    Account account = GetCurrentAccount();
        //    var _bll = new SysPersonBLL();
        //    var person = _bll.GetById(account.Id);
        //    return person;
        //}


       
    }
}
