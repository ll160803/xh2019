using NFine.Application.Hrm;
using NFine.Application.SystemManage;
using NFine.Code;
using NFine.Domain.Entity.Hrm;
using NFine.Domain.Entity.SystemManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace NFine.Web.Areas.Hrm.Controllers
{
    public class AttendanceController : ControllerBase
    {
        //
        // GET: /Hrm/Attendance/
        private string IsDoctor = OperatorProvider.Provider.GetCurrent().Is_Doctor;
        private RoleAuthorizeApp roleAuthorizeApp = new RoleAuthorizeApp();
        public ActionResult AttendanceIndex()
        {
            return View();
        }
        public ActionResult HistoryRecordDetail(string id)
        {
            ViewBag.id = id;
            return View();
        }
        /// <summary>
        /// 科室主任审核页面
        /// </summary>
        /// <returns></returns>
        public ActionResult AttendanceAuditIndex()
        {
            return View();
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetHistoryRecord(string id, Pagination pagination, string keyword)
        {
            System.Linq.Expressions.Expression<Func<AttendanceRecordEntity, bool>> expression = ExtLinq.True<AttendanceRecordEntity>();

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
            if (!string.IsNullOrEmpty(keyword))
            {
                var keyPress = ExtLinq.True<AttendanceRecordEntity>();
                keyPress = keyPress.And(t => t.AttendDate == keyword);
                expression = expression.And(keyPress);
            }
            if (IsDoctor != "3")
            {
                //这里是取  Flag为空 或者是医生、护士的
                expression = expression.And(p => p.Flag != (IsDoctor == "2" ? true : false));
            }
            AttendanceRecordApp appRecord = new AttendanceRecordApp();

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
        /// 科室主任考勤页面
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pagination"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetHistoryAuditRecord(string id, Pagination pagination, string keyword)
        {
            System.Linq.Expressions.Expression<Func<AttendanceRecordEntity, bool>> expression = ExtLinq.True<AttendanceRecordEntity>();

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
            if (!string.IsNullOrEmpty(keyword))
            {
                var keyPress = ExtLinq.True<AttendanceRecordEntity>();
                keyPress = keyPress.And(t => t.AttendDate == keyword);
                expression = expression.And(keyPress);
            }
            // expression = expression.And(p => p.Flag == IsDoctor);
            expression = expression.And(p => p.State > 1);//提交的都可以看到
            AttendanceRecordApp appRecord = new AttendanceRecordApp();

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
        /// 尚未真正的实现
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pagination"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetAskLeaveSumRecord(string id, Pagination pagination, string keyword)
        {
            System.Linq.Expressions.Expression<Func<AskForLeaveEntity, bool>> expression = ExtLinq.True<AskForLeaveEntity>();

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
            if (IsDoctor != "3")
            {
                expression = expression.And(p => p.DoctorOrNurser == (IsDoctor == "1" ? true : false));
            }
            expression = expression.And(p => p.IsNew == true & p.State > 1);//提交过的 是最新的 是护士或者医生  

            if (string.IsNullOrEmpty(keyword))
            {
                keyword = DateTime.Now.AddMonths(-1).ToString("yyyy-MM");
            }
            DateTime dtfirst = Convert.ToDateTime(keyword + "-01");
            DateTime dtlast = dtfirst.AddMonths(1).AddDays(-1);
            var keyPress = ExtLinq.True<AskForLeaveEntity>();
            keyPress = keyPress.And(t => t.StartDate <= dtlast & t.EndDate >= dtfirst);
            expression = expression.And(keyPress);

            AskForLeaveApp appRecord = new AskForLeaveApp();
            var listAskLeave = appRecord.GetList(new Pagination { page = 1, sidx = "F_Id", sord = "asc", rows = int.MaxValue }, expression);
            HrmUserApp hrmUserApp = new HrmUserApp();
            var hrmUserList = hrmUserApp.GetList(pagination, authorizedata, IsDoctor);
            var askTypeList = new ItemsDetailApp().GetItemList("AskLeaveType");//请假类型表
            foreach (var user in hrmUserList)
            {
                var comments = "";
                foreach (var askType in askTypeList)
                {
                    var list = listAskLeave.Where(p => p.AskTypeId == askType.F_Id & p.HrmUserId == user.F_Id);
                    var days = 0;
                    foreach (var item in list)
                    {
                        days += Common.CalcDays(item.StartDate.Value, item.EndDate.Value, keyword);
                    }
                    if (days > 0)
                    {
                        comments += askType.F_ItemName + "：" + days + "天；";
                    }
                }
                if (!string.IsNullOrEmpty(user.ZCGBZ))
                {
                    comments += user.ZCGBZ + "；";
                }
                if (!string.IsNullOrEmpty(user.ZTQBZ))
                {
                    comments += user.ZTQBZ + "；";
                }
                if (comments == "")
                {
                    comments = "全勤";
                }
                user.F_Description = comments;
            }
            var data = new
            {
                rows = hrmUserList,
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }
        [HttpPost]
        public ActionResult GetAskLeaveSumRecordExport(string id, Pagination pagination, string keyword, string titleAndField)
        {
            pagination.page = 1;
            pagination.rows = int.MaxValue;
            System.Linq.Expressions.Expression<Func<AskForLeaveEntity, bool>> expression = ExtLinq.True<AskForLeaveEntity>();

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
            if (IsDoctor != "3")
            {
                expression = expression.And(p => p.DoctorOrNurser == (IsDoctor == "1" ? true : false));
            }
            expression = expression.And(p => p.IsNew == true & p.State > 1);//提交过的 是最新的 是护士或者医生  

            if (string.IsNullOrEmpty(keyword))
            {
                keyword = DateTime.Now.AddMonths(-1).ToString("yyyy-MM");
            }
            DateTime dtfirst = Convert.ToDateTime(keyword + "-01");
            DateTime dtlast = dtfirst.AddMonths(1).AddDays(-1);
            var keyPress = ExtLinq.True<AskForLeaveEntity>();
            keyPress = keyPress.And(t => t.StartDate <= dtlast & t.EndDate >= dtfirst);
            expression = expression.And(keyPress);

            AskForLeaveApp appRecord = new AskForLeaveApp();
            var listAskLeave = appRecord.GetList(new Pagination { page = 1, sidx = "F_Id", sord = "asc", rows = int.MaxValue }, expression);
            HrmUserApp hrmUserApp = new HrmUserApp();
            var hrmUserList = hrmUserApp.GetList(pagination, authorizedata, IsDoctor);
            var askTypeList = new ItemsDetailApp().GetItemList("AskLeaveType");//请假类型表
            foreach (var user in hrmUserList)
            {
                var comments = "";
                foreach (var askType in askTypeList)
                {
                    var list = listAskLeave.Where(p => p.AskTypeId == askType.F_Id & p.HrmUserId == user.F_Id);
                    var days = 0;
                    foreach (var item in list)
                    {
                        days += Common.CalcDays(item.StartDate.Value, item.EndDate.Value, keyword);
                    }
                    if (days > 0)
                    {
                        comments += askType.F_ItemName + "：" + days + "天；";
                    }
                }
                if (!string.IsNullOrEmpty(user.ZCGBZ))
                {
                    comments += user.ZCGBZ + "；";
                }
                if (!string.IsNullOrEmpty(user.ZTQBZ))
                {
                    comments += user.ZTQBZ + "；";
                }
                if (comments == "")
                {
                    comments = "全勤";
                }
                user.F_Description = comments;
            }

            var dicFields = HandleTitelAndField.GetTitleAndField(titleAndField, 12, 15, 18);
            var downUrl = NPOIWriteExcel.OutputExcel(hrmUserList, dicFields, new ExcelCaption { CaptionName = "考勤记录表", Height = 24 });

            return Success("下载成功", downUrl);

        }

        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(string data, string keyValue)
        {
            try
            {
                List<AttendanceNote> listData = new List<AttendanceNote>();
                System.Web.Script.Serialization.JavaScriptSerializer json = new System.Web.Script.Serialization.JavaScriptSerializer();
                listData = json.Deserialize<List<AttendanceNote>>(data);

                AttendanceRecordApp app = new AttendanceRecordApp();
                AttendanceRecordDApp app_d = new AttendanceRecordDApp();

                bool? flag = null;
                if (IsDoctor == "2") flag = false;
                if (IsDoctor == "1") flag = true;
                var entity = new AttendanceRecordEntity
                {
                    AttendDate = keyValue,
                    Flag = flag,
                    OrganizeId = OperatorProvider.Provider.GetCurrent().DepartmentId,
                    State = 1,
                    SubmitMan = OperatorProvider.Provider.GetCurrent().UserName,
                    SubmitDate = DateTime.Now
                };

                app.SubmitForm(entity, "");

                List<AttendanceRecordDEntity> list_d = new List<AttendanceRecordDEntity>();
                foreach (var item in listData)
                {
                    AttendanceRecordDEntity ask_d = new AttendanceRecordDEntity { F_Id = Guid.NewGuid().ToString(), Base_Id = entity.F_Id, hrm_user_Id = item.Id, Note = item.Note, OrganizeId = item.OrgId };
                    list_d.Add(ask_d);

                }
                app_d.InsertForm(list_d);

            }
            catch (Exception ex)
            {
                return Error("创建考勤失败,原因:" + ex.Message);
            }
            return Success("创建成功。");
        }

        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitAndSaveForm(string data, string keyValue)
        {
            try
            {
                List<AttendanceNote> listData = new List<AttendanceNote>();
                System.Web.Script.Serialization.JavaScriptSerializer json = new System.Web.Script.Serialization.JavaScriptSerializer();
                listData = json.Deserialize<List<AttendanceNote>>(data);

                AttendanceRecordApp app = new AttendanceRecordApp();
                AttendanceRecordDApp app_d = new AttendanceRecordDApp();
                bool? flag = null;
                if (IsDoctor == "2") flag = false;
                if (IsDoctor == "1") flag = true;
                var temp_id = Common.GuId();
                var entity = new AttendanceRecordEntity
                {
                    F_Id = temp_id,
                    AttendDate = keyValue,
                    Flag = flag,
                    OrganizeId = OperatorProvider.Provider.GetCurrent().DepartmentId,
                    State = 2,//提交
                    SubmitMan = OperatorProvider.Provider.GetCurrent().UserName,
                    SubmitDate = DateTime.Now

                };
                app.SubmitForm(entity, "");

                List<AttendanceRecordDEntity> list_d = new List<AttendanceRecordDEntity>();
                foreach (var item in listData)
                {
                    AttendanceRecordDEntity ask_d = new AttendanceRecordDEntity { F_Id = Guid.NewGuid().ToString(), Base_Id = entity.F_Id, hrm_user_Id = item.Id, Note = item.Note, OrganizeId = item.OrgId };
                    list_d.Add(ask_d);

                }
                app_d.InsertForm(list_d);

                System.Linq.Expressions.Expression<Func<ViewHrmAttandaceSapEntity, bool>> expression = ExtLinq.True<ViewHrmAttandaceSapEntity>();
                expression = expression.And(t => t.Base_Id == entity.F_Id);
                var listAttendance = new ViewHrmAttandaceSapApp().GetList(new Pagination { page = 1, rows = int.MaxValue, sidx = "F_Id", sord = "asc" }, expression);
                Code.SAPHandle.SendAttendanceToSap(listAttendance);

            }
            catch (Exception ex)
            {
                return Error("创建考勤失败,原因:" + ex.Message);
            }
            return Success("创建成功。");
        }

        [HttpPost]
        [HandlerAjaxOnly]
        public ActionResult QC_temp()
        {
            try
            {
               

                System.Linq.Expressions.Expression<Func<AttendanceRecordEntity, bool>> expression1 = ExtLinq.True<AttendanceRecordEntity>();
                expression1 = expression1.And(t => t.State > 1);
                expression1 = expression1.And(t => t.AttendDate == "2020-04");
                AttendanceRecordApp app = new AttendanceRecordApp();
                var listData=app.GetList(new Pagination { page = 1, rows = int.MaxValue, sidx = "F_Id", sord = "asc" }, expression1);
                foreach (var record in listData)
                {

                    System.Linq.Expressions.Expression<Func<ViewHrmAttandaceSapEntity, bool>> expression = ExtLinq.True<ViewHrmAttandaceSapEntity>();
                    expression = expression.And(t => t.Base_Id == record.F_Id);
                    var listAttendance = new ViewHrmAttandaceSapApp().GetList(new Pagination { page = 1, rows = int.MaxValue, sidx = "F_Id", sord = "asc" }, expression);
                    Code.SAPHandle.SendAttendanceToSap(listAttendance);
                }

            }
            catch (Exception ex)
            {
                return Error("创建考勤失败,原因:" + ex.Message);
            }
            return Success("创建成功。");
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetHistoryDetailRecord(string id, Pagination pagination, string keyword)
        {
            System.Linq.Expressions.Expression<Func<ViewAttendanceRecordDEntity, bool>> expression = ExtLinq.True<ViewAttendanceRecordDEntity>();
            expression = expression.And(t => t.Base_Id == id);
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.NACHN.Contains(keyword) || t.PERNR.Contains(keyword));
            }
            if (IsDoctor != "3")
            {
                expression = expression.And(t => t.RYLB == IsDoctor);
            }
            ViewAttendanceRecordDApp hrmUserApp = new ViewAttendanceRecordDApp();

            var hrmUserList = hrmUserApp.GetList(pagination, expression);
            var data = new
            {
                rows = hrmUserList,
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());

        }

        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult GetHistoryDetailRecordExport(string id, Pagination pagination, string keyword, string titleAndField)
        {
            System.Linq.Expressions.Expression<Func<ViewAttendanceRecordDEntity, bool>> expression = ExtLinq.True<ViewAttendanceRecordDEntity>();
            expression = expression.And(t => t.Base_Id == id);
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.NACHN.Contains(keyword) || t.PERNR.Contains(keyword));
            }
            if (IsDoctor != "3")
            {
                expression = expression.And(t => t.RYLB == IsDoctor);
            }
            ViewAttendanceRecordDApp hrmUserApp = new ViewAttendanceRecordDApp();
            pagination.page = 1;
            pagination.rows = int.MaxValue;
            var hrmUserList = hrmUserApp.GetList(pagination, expression);


            var rows = hrmUserList;

            var dicFields = HandleTitelAndField.GetTitleAndField(titleAndField, 12, 15, 18);
            var downUrl = NPOIWriteExcel.OutputExcel<ViewAttendanceRecordDEntity>(rows, dicFields, new ExcelCaption { CaptionName = "考勤记录表", Height = 24 });

            return Success("下载成功", downUrl);

        }
        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitLeave(string keyValue)
        {
            AttendanceRecordApp appRecord = new AttendanceRecordApp();
            AttendanceRecordEntity entity = appRecord.GetForm(keyValue);
            if (!(entity.State == 1))
            {
                return Error("此请假已经提交，请勿重复操作，具体请联系管理员。");
            }
            entity.State = (int)AskLeaveStateType.已提交;
            entity.SubmitDate = DateTime.Now;
            entity.SubmitMan = OperatorProvider.Provider.GetCurrent().UserName;
            appRecord.SubmitForm(entity, keyValue);

            System.Linq.Expressions.Expression<Func<ViewHrmAttandaceSapEntity, bool>> expression = ExtLinq.True<ViewHrmAttandaceSapEntity>();
            expression = expression.And(t => t.Base_Id == keyValue);
            var listAttendance = new ViewHrmAttandaceSapApp().GetList(new Pagination { page = 1, rows = int.MaxValue, sidx = "F_Id", sord = "asc" }, expression);
            Code.SAPHandle.SendAttendanceToSap(listAttendance);

            return Success("提交成功。");
        }
        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteLeave(string keyValue)
        {
            AttendanceRecordApp appRecord = new AttendanceRecordApp();
            AttendanceRecordDApp appDRecord = new AttendanceRecordDApp();
            AttendanceRecordEntity entity = appRecord.GetForm(keyValue);
            if (entity.State != (int)AskLeaveStateType.未提交)
            {
                return Error("已提交数据不能删除，具体请联系管理员。");
            }
            appDRecord.Delete(entity.F_Id);
            appRecord.Delete(entity);
            return Success("删除成功。");
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult AuditSubmit(string keyValue, int state, string suggestion)
        {
            AttendanceRecordApp appRecord = new AttendanceRecordApp();
            AttendanceRecordEntity entity = appRecord.GetForm(keyValue);
            if (entity.State > 2)
            {
                return Error("此请假已经审核，请勿重复操作，具体请联系管理员。");
            }

            entity.State = state;
            entity.AuditMan = OperatorProvider.Provider.GetCurrent().UserName;
            entity.AuditDate = DateTime.Now;
            entity.F_Description = suggestion;
            appRecord.SubmitForm(entity, keyValue);
            if (state == 3)//审核成功需要发送SAP
            {
                System.Linq.Expressions.Expression<Func<ViewHrmAttandaceSapEntity, bool>> expression = ExtLinq.True<ViewHrmAttandaceSapEntity>();
                expression = expression.And(t => t.Base_Id == keyValue);
                var listAttendance = new ViewHrmAttandaceSapApp().GetList(new Pagination { page = 1, rows = int.MaxValue, sidx = "F_Id", sord = "asc" }, expression);
                Code.SAPHandle.SendAttendanceToSap(listAttendance);
            }
            return Success("审核成功。");
        }
    }
}
