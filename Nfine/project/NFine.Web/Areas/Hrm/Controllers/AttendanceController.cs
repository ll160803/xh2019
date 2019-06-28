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
        private bool IsDoctor = OperatorProvider.Provider.GetCurrent().Is_Doctor == UserType.医生.ToString();
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
            expression = expression.And(p => p.Flag == IsDoctor);
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
            expression = expression.And(p => p.Flag == IsDoctor & p.IsNew == true & p.State > 1);//提交过的 是最新的 是护士或者医生  

            if (string.IsNullOrEmpty(keyword))
            {
                keyword = DateTime.Now.ToString("yyyy-MM");
            }
            DateTime dtfirst = Convert.ToDateTime(keyword + "-01");
            DateTime dtlast = dtfirst.AddMonths(1).AddDays(-1);
            var keyPress = ExtLinq.True<AskForLeaveEntity>();
            keyPress = keyPress.And(t => t.StartDate <= dtlast & t.EndDate >= dtfirst);
            expression = expression.And(keyPress);

            AskForLeaveApp appRecord = new AskForLeaveApp();
            var listAskLeave = appRecord.GetList(new Pagination { page = 1, sidx = "F_Id", sord = "asc", rows = int.MaxValue }, expression);
            HrmUserApp hrmUserApp = new HrmUserApp();
            var hrmUserList = hrmUserApp.GetList(pagination, authorizedata);
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
                var entity = new AttendanceRecordEntity
                {
                    AttendDate = keyValue,
                    Flag = false,
                    OrganizeId = OperatorProvider.Provider.GetCurrent().DepartmentId,
                    State = 1,
                    SubmitMan = OperatorProvider.Provider.GetCurrent().UserName
                };
                app.SubmitForm(entity, "");

                List<AttendanceRecordDEntity> list_d = new List<AttendanceRecordDEntity>();
                foreach (var item in listData)
                {
                    AttendanceRecordDEntity ask_d = new AttendanceRecordDEntity { F_Id = Guid.NewGuid().ToString(), Base_Id = entity.F_Id, hrm_user_Id = item.Id, Note = item.Note };
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
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetHistoryDetailRecord(string id, Pagination pagination, string keyword)
        {
            System.Linq.Expressions.Expression<Func<ViewAttendanceRecordDEntity, bool>> expression = ExtLinq.True<ViewAttendanceRecordDEntity>();
            expression = expression.And(t => t.Base_Id == id);
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



    }
}
