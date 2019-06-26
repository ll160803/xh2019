using NFine.Code;
using NFine.Domain.Entity.Hrm;
using NFine.Application.Hrm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using NFine.Domain.Entity.SystemManage;
using NFine.Application.SystemManage;

namespace NFine.Web.Areas.Hrm.Controllers
{
    public class AskForLeaveController : ControllerBase
    {
        private string IsDoctor = OperatorProvider.Provider.GetCurrent().Is_Doctor;
        private ViewAskForLeaveApp viewApp = new ViewAskForLeaveApp();
        private AskForLeaveApp askApp = new AskForLeaveApp();
        private RoleAuthorizeApp roleAuthorizeApp = new RoleAuthorizeApp();
        // GET: /Hrm/AskForLeave/
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">医生是1护士是2</param>
        /// <returns></returns>
        public ActionResult AskIndex(string id)
        {
            ViewBag.id = IsDoctor;
            return View();
        }
        public ActionResult AskAuditIndex(string id)
        {
            ViewBag.id = IsDoctor;
            return View();
        }
        public ActionResult AskLastAuditIndex(string id)
        {
            ViewBag.id = IsDoctor;
            return View();
        }
        public ActionResult AskLeaveHistoryRecord(string id)
        {
            ViewBag.id = id;
            return View();
        }
        public ActionResult HistoryRecordDetail(string id)
        {
            ViewBag.id = id;
            return View();
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(string id, Pagination pagination, string keyword, int state = 1)
        {
            System.Linq.Expressions.Expression<Func<ViewAskForLeaveEntity, bool>> expression = ExtLinq.True<ViewAskForLeaveEntity>();

            var authorizedata = new List<RoleAuthorizeEntity>();
            var userId = OperatorProvider.Provider.GetCurrent().UserId;
            if (!string.IsNullOrEmpty(userId))
            {
                authorizedata = roleAuthorizeApp.GetOrganizeList(userId);
            }
            if (authorizedata.Count == 0)
            {
                var orgId = OperatorProvider.Provider.GetCurrent().CompanyId;//当前用户所在公司ID
                expression = expression.And(p => p.OrganizeId == orgId);
            }
            else
            {
                var orgIds = "," + string.Join(",", authorizedata.Select(u => u.F_ItemId)) + ",";
                expression = expression.And(p => orgIds.Contains("," + p.OrganizeId + ","));
            }
            if (state != -1)
            {
                if (state == 1)
                {
                    expression = expression.And(p => p.State == 0 || p.State == 1);
                }
                else
                {
                    expression = expression.And(p => p.State == state);
                }

            }
            if (!string.IsNullOrEmpty(id))
            {
                expression = expression.And(p => p.RYLB == id);//医生还是护士
            }
            if (!string.IsNullOrEmpty(keyword))
            {
                var keyPress = ExtLinq.True<ViewAskForLeaveEntity>();
                keyPress = keyPress.And(t => t.PERNR.Contains(keyword));
                keyPress = keyPress.Or(t => t.NACHN.Contains(keyword));
                expression = expression.And(keyPress);
            }

            var data = new
            {
                rows = viewApp.GetList(pagination, expression),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetOrgAuditGridJson(string id, Pagination pagination, string keyword, int state = 2)//除了 病假、产假 都是由自己科室审核
        {
            System.Linq.Expressions.Expression<Func<ViewAskForLeaveEntity, bool>> expression = ExtLinq.True<ViewAskForLeaveEntity>();
            var authorizedata = new List<RoleAuthorizeEntity>();
            var userId = OperatorProvider.Provider.GetCurrent().UserId;
            if (!string.IsNullOrEmpty(userId))
            {
                authorizedata = roleAuthorizeApp.GetOrganizeList(userId);
            }
            if (authorizedata.Count == 0)
            {
                var orgId = OperatorProvider.Provider.GetCurrent().CompanyId;//当前用户所在公司ID
                expression = expression.And(p => p.OrganizeId == orgId);
            }
            else
            {
                var orgIds = "," + string.Join(",", authorizedata.Select(u => u.F_ItemId)) + ",";
                expression = expression.And(p => orgIds.Contains("," + p.OrganizeId + ","));
            }

            expression = expression.And(p => p.Flag == false);//是否病假产假
            if (state == 0)
            {
                expression = expression.And(p => p.State == 2 || p.State == 3 || p.State == 4);
            }
            else
            {
                expression = expression.And(p => p.State == state);
            }
            //if (!string.IsNullOrEmpty(id))//主任审核部分护士医生
            //{
            //    expression = expression.And(p => p.RYLB == id);//医生还是护士
            //}
            if (!string.IsNullOrEmpty(keyword))
            {
                var keyPress = ExtLinq.True<ViewAskForLeaveEntity>();
                keyPress = keyPress.And(t => t.PERNR.Contains(keyword));
                keyPress = keyPress.Or(t => t.NACHN.Contains(keyword));
                expression = expression.And(keyPress);
            }

            var data = new
            {
                rows = viewApp.GetList(pagination, expression),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }
        /// <summary>
        /// 病假、产假由职工保健科来审核
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pagination"></param>
        /// <param name="keyword"></param>
        /// <param name="state">4是推送SAP</param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetLastAuditGridJson(string id, Pagination pagination, string keyword, int state = 2)
        {
            System.Linq.Expressions.Expression<Func<ViewAskForLeaveEntity, bool>> expression = ExtLinq.True<ViewAskForLeaveEntity>();
            var orgId = OperatorProvider.Provider.GetCurrent().CompanyId;//当前用户所在公司ID
            expression = expression.And(p => p.OrganizeId == orgId & (p.Flag == true));
            //if (!string.IsNullOrEmpty(id))//保健科不分医生和护士
            //{
            //    expression = expression.And(p => p.RYLB == id);//医生还是护士
            //}
            if (state == 0)
            {
                expression = expression.And(p => p.State == 2 || p.State == 3 || p.State == 4);
            }
            else
            {
                expression = expression.And(p => p.State == state);
            }
            if (!string.IsNullOrEmpty(keyword))
            {
                var keyPress = ExtLinq.True<ViewAskForLeaveEntity>();
                keyPress = keyPress.And(t => t.PERNR.Contains(keyword));
                keyPress = keyPress.Or(t => t.NACHN.Contains(keyword));
                expression = expression.And(keyPress);
            }

            var data = new
            {
                rows = viewApp.GetList(pagination, expression),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }
        /// <summary>
        /// 科室主任审核记录
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pagination"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetHistoryRecord(string id, Pagination pagination, string keyword)
        {
            System.Linq.Expressions.Expression<Func<ViewHrmAskForLeaveRecordEntity, bool>> expression = ExtLinq.True<ViewHrmAskForLeaveRecordEntity>();
            var orgId = OperatorProvider.Provider.GetCurrent().CompanyId;//当前用户所在公司ID
            expression = expression.And(p => p.OragnizeId == orgId & (p.Flag == false));
            //if (!string.IsNullOrEmpty(id))//保健科不分医生和护士
            //{
            //    expression = expression.And(p => p.RYLB == id);//医生还是护士
            //}
            if (!string.IsNullOrEmpty(keyword))
            {
                var keyPress = ExtLinq.True<ViewHrmAskForLeaveRecordEntity>();
                keyPress = keyPress.And(t => t.F_FullName.Contains(keyword));
                keyPress = keyPress.Or(t => t.F_RealName.Contains(keyword));
                expression = expression.And(keyPress);
            }
            ViewHrmAskForLeaveRecordApp appRecord = new ViewHrmAskForLeaveRecordApp();

            var data = new
            {
                rows = appRecord.GetList(pagination, expression),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }

        /// <summary>
        /// 考勤记录详情
        /// </summary>
        /// <param name="id">主表Id</param>
        /// <param name="pagination"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetHistoryDetailRecord(string id, Pagination pagination, string keyword)
        {
            HistoryRecordDetailApp appRecord = new HistoryRecordDetailApp();
            System.Linq.Expressions.Expression<Func<HistoryRecordDetailEntity, bool>> expression = ExtLinq.True<HistoryRecordDetailEntity>();
            expression = expression.And(p => p.Base_Id == id);
            if (!string.IsNullOrEmpty(keyword))
            {
                var keyPress = ExtLinq.True<HistoryRecordDetailEntity>();
                keyPress = keyPress.And(t => t.PERNR.Contains(keyword));
                keyPress = keyPress.Or(t => t.NACHN.Contains(keyword));
                expression = expression.And(keyPress);
            }
            var data = new
            {
                rows = appRecord.GetList(pagination, expression),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }

        /// <summary>
        /// 保健科审核记录
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pagination"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetHistoryBJRecord(string id, Pagination pagination, string keyword)
        {
            System.Linq.Expressions.Expression<Func<ViewHrmAskForLeaveRecordEntity, bool>> expression = ExtLinq.True<ViewHrmAskForLeaveRecordEntity>();
            var orgId = OperatorProvider.Provider.GetCurrent().CompanyId;//当前用户所在公司ID
            expression = expression.And(p => p.Flag == true);
            //if (!string.IsNullOrEmpty(id))//保健科不分医生和护士
            //{
            //    expression = expression.And(p => p.RYLB == id);//医生还是护士
            //}
            if (!string.IsNullOrEmpty(keyword))
            {
                var keyPress = ExtLinq.True<ViewHrmAskForLeaveRecordEntity>();
                keyPress = keyPress.And(t => t.F_FullName.Contains(keyword));
                keyPress = keyPress.Or(t => t.F_RealName.Contains(keyword));
                expression = expression.And(keyPress);
            }
            ViewHrmAskForLeaveRecordApp appRecord = new ViewHrmAskForLeaveRecordApp();

            var data = new
            {
                rows = appRecord.GetList(pagination, expression),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(string keyValue)
        {
            var data = viewApp.GetForm(keyValue);
            return Content(data.ToJson());
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(AskForLeaveEntity userEntity, string keyValue, string Flag)
        {
            if (!string.IsNullOrEmpty(Flag))
            {
                userEntity.Flag = Flag == "1" ? true : false;
            }
            if (string.IsNullOrEmpty(keyValue))
            {
                userEntity.State = 1;//草稿状态
                userEntity.IsNew = true;//激活的请假
                userEntity.AskSort = 1;//默认是1

            }
            else
            {
                if (userEntity.State != 1 || userEntity.IsNew == false)
                {
                    return Error("错误操作。");
                }
            }
            // userEntity.OrganizeId= OperatorProvider.Provider.GetCurrent().CompanyId;//当前科室
            var hasList = askApp.GetLeaveList(userEntity.HrmUserId, userEntity.StartDate.Value, userEntity.EndDate.Value, keyValue);
            if (hasList.Count > 0)
            {
                return Error("此员工在请假时间区间内，已经有请假记录，请核实后重新提交");
            }
            askApp.InsertForm(userEntity, keyValue);
            return Success("操作成功。");
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitAndSaveForm(AskForLeaveEntity userEntity, string keyValue, string Flag)
        {
            if (!string.IsNullOrEmpty(Flag))
            {
                userEntity.Flag = Flag == "1" ? true : false;
            }
            if (string.IsNullOrEmpty(keyValue))
            {
                userEntity.State = 1;//草稿状态
                userEntity.IsNew = true;//激活的请假
                userEntity.AskSort = 1;//默认是1

            }
            else
            {
                if (userEntity.State != 1 || userEntity.IsNew == false)
                {
                    return Error("错误操作。");
                }
            }
            userEntity.State = 2;//改为提交操作
            // userEntity.OrganizeId= OperatorProvider.Provider.GetCurrent().CompanyId;//当前科室
            var hasList = askApp.GetLeaveList(userEntity.HrmUserId, userEntity.StartDate.Value, userEntity.EndDate.Value, keyValue);
            if (hasList.Count > 0)
            {
                return Error("此员工在请假时间区间内，已经有请假记录，请核实后重新提交");
            }
            askApp.InsertForm(userEntity, keyValue);
            return Success("操作成功。");
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitFormModify(AskForLeaveEntity userEntity, string keyValue, string Flag, int state = 1)
        {
            if (!string.IsNullOrEmpty(Flag))
            {
                userEntity.Flag = Flag == "1" ? true : false;
            }
            userEntity.State = state;//草稿状态
            userEntity.IsNew = true;//激活的请假
            userEntity.AskSort = userEntity.AskSort + 1;//默认是增加1个
            userEntity.Ref_Id = userEntity.Ref_Id;//请假和请假改登之间的唯一标识
            // userEntity.OrganizeId= OperatorProvider.Provider.GetCurrent().CompanyId;//当前科室
            var hasList = askApp.GetLeaveList(userEntity.HrmUserId, userEntity.StartDate.Value, userEntity.EndDate.Value, keyValue);
            if (hasList.Count > 0)
            {
                return Error("此员工在请假时间区间内，已经有请假记录，请核实后重新提交");
            }
            var oldEntity = askApp.GetForm(keyValue);
            oldEntity.IsNew = false;//之前的请假记录不激活
            userEntity.F_Id = Guid.NewGuid().ToString();
            askApp.SubmitForm(oldEntity, keyValue);//之前的请假记录不激活
            askApp.SubmitForm(userEntity, "");
            return Success("操作成功。");
        }
        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(string keyValue)
        {
            AskForLeaveEntity entity = askApp.GetForm(keyValue);
            if (entity.State != 1 || entity.IsNew == false)
            {
                return Error("此请假不能删除，具体请联系管理员。");
            }
            askApp.Delete(entity);
            return Success("删除成功。");
        }
        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitLeave(string keyValue)
        {
            AskForLeaveEntity entity = askApp.GetForm(keyValue);
            if (entity.State != 1 || entity.IsNew == false)
            {
                return Error("此请假已经提交，请勿重复操作，具体请联系管理员。");
            }
            entity.State = 2;
            askApp.SubmitForm(entity, keyValue);
            return Success("提交成功。");
        }
        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitAudit(string keyValue)
        {
            AskForLeaveEntity entity = askApp.GetForm(keyValue);
            if (entity.State != 1 || entity.IsNew == false)
            {
                return Error("此请假已经提交，请勿重复操作，具体请联系管理员。");
            }
            entity.State = 3;
            askApp.SubmitForm(entity, keyValue);
            return Success("审核成功。");
        }
        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult AuditSubmitLeave(string keyValue, int state, string suggestion)
        {
            AskForLeaveEntity entity = askApp.GetForm(keyValue);
            if (entity.State != 2 || entity.IsNew == false)
            {
                return Error("此请假已经审核，请勿重复操作，具体请联系管理员。");
            }
            if (entity.Flag == true)
            {
                entity.LastAudit = OperatorProvider.Provider.GetCurrent().UserName;
                entity.LastAuditTime = DateTime.Now;
            }
            if (entity.Flag == false)
            {
                entity.LeaderAudit = OperatorProvider.Provider.GetCurrent().UserName;
                entity.LeaderAuditTime = DateTime.Now;
            }
            entity.State = state;
            entity.Suggestion = suggestion;
            askApp.SubmitForm(entity, keyValue);
            return Success("审核成功。");
        }
        /// <summary>
        /// 推送数据到SAP 科室主任
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SendLeaveToSapByLeader(string type)//
        {
            try
            {
                HrmAskForLeaveRecordApp app = new HrmAskForLeaveRecordApp();
                var entity = new HrmAskForLeaveRecordEntity
                {
                    OragnizeId = OperatorProvider.Provider.GetCurrent().CompanyId,
                    UserId = OperatorProvider.Provider.GetCurrent().UserId,
                    Flag = false
                };
                app.SubmitForm(entity, "");
                HrmAskForLeaveRecordDApp app_d = new HrmAskForLeaveRecordDApp();
                StringBuilder sb = new StringBuilder();
                sb.Append("select *  from hrm_AskForLeave where ");
                sb.AppendFormat(" OrganizeId='{0}' ", OperatorProvider.Provider.GetCurrent().CompanyId);//科室主任只上传本科室的
                sb.AppendFormat(" and state=3 ");
                sb.AppendFormat(" and Flag=0 ");//不是产、病假
                var listIds = askApp.GetIdList(sb.ToString());
                if (listIds.Count <= 0)
                {
                    return Error("没有需要推送的数据,请审核后，重新操作。");
                }
                List<HrmAskForLeaveRecordDEntity> list_d = new List<HrmAskForLeaveRecordDEntity>();
                foreach (var item in listIds)
                {
                    HrmAskForLeaveRecordDEntity ask_d = new HrmAskForLeaveRecordDEntity { F_Id = Guid.NewGuid().ToString(), Base_Id = entity.F_Id, Ask_Id = item.F_Id };
                    list_d.Add(ask_d);
                    item.State = 4;
                    askApp.SubmitForm(item, item.F_Id);
                }

                app_d.InsertForm(list_d);

            }
            catch (Exception ex)
            {
                return Error("推送SAP失败,原因:" + ex.Message);
            }
            return Success("推送SAP成功。");
        }

        /// <summary>
        /// 推送数据到SAP 保健科
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SendLeaveToSap(string id)//
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("select *  from hrm_AskForLeave where ");
                // sb.AppendFormat(" OrganizeId='{0}' ", OperatorProvider.Provider.GetCurrent().CompanyId);//科室主任只上传本科室的
                sb.AppendFormat("  state=3 ");
                sb.AppendFormat(" and Flag=1 ");//是产、病假
                var listIds = askApp.GetIdList(sb.ToString());
                if (listIds.Count <= 0)
                {
                    return Error("没有需要推送的数据,请审核后，重新操作。");
                }
                var orgList = listIds.Select(p => new { orgid = p.OrganizeId, userid = p.F_CreatorUserId }).Distinct();
                foreach (var org in orgList)
                {
                    HrmAskForLeaveRecordApp app = new HrmAskForLeaveRecordApp();
                    var entity = new HrmAskForLeaveRecordEntity
                    {
                        OragnizeId = org.orgid,
                        UserId = org.userid,
                        Flag = true
                    };
                    app.SubmitForm(entity, "");
                    HrmAskForLeaveRecordDApp app_d = new HrmAskForLeaveRecordDApp();

                    List<HrmAskForLeaveRecordDEntity> list_d = new List<HrmAskForLeaveRecordDEntity>();
                    foreach (var item in listIds.Where(p => p.OrganizeId == org.orgid && p.F_CreatorUserId == org.userid))
                    {
                        HrmAskForLeaveRecordDEntity ask_d = new HrmAskForLeaveRecordDEntity { F_Id = Guid.NewGuid().ToString(), Base_Id = entity.F_Id, Ask_Id = item.F_Id };
                        list_d.Add(ask_d);
                        item.State = 4;
                        askApp.SubmitForm(item, item.F_Id);
                    }

                    app_d.InsertForm(list_d);
                }

            }
            catch (Exception ex)
            {
                return Error("推送SAP失败,原因:" + ex.Message);
            }
            return Success("推送SAP成功。");
        }
    }
}
