using NFine.Application.Hrm;
using NFine.Application.SystemManage;
using NFine.Code;
using NFine.Domain.Entity.Hrm;
using NFine.Domain.Entity.SystemManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NFine.Web.Areas.Hrm.Controllers
{
    public class SapUserController : ControllerBase
    {
        private string IsDoctor = OperatorProvider.Provider.GetCurrent().Is_Doctor;
        //
        // GET: /Hrm/SapUser/
        private HrmUserApp userApp = new HrmUserApp();
        private AskForLeaveApp askApp = new AskForLeaveApp();
        private RoleAuthorizeApp roleAuthorizeApp = new RoleAuthorizeApp();
        public ActionResult Out(string id)
        {
            ViewBag.id = IsDoctor;
            return View();
        }
        public ActionResult In(string id)
        {
            ViewBag.id = IsDoctor;
            return View();
        }
        public virtual ActionResult UserOrganize()
        {
            return View();
        }
        [HttpPost]
        [HandlerAjaxOnly]
        public JsonResult GetComboGridJson(string id, string order, string sort, string keyword, int page = 1, int rows = int.MaxValue)
        {
            Pagination pagination = new Pagination { page = page, rows = rows, sidx = order, sord = sort };
            System.Linq.Expressions.Expression<Func<HrmUserEntity, bool>> expression = ExtLinq.True<HrmUserEntity>();
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
                expression = expression.And(p => p.RYLB == IsDoctor);
            }

            if (!string.IsNullOrEmpty(keyword))
            {
                var keyPress = ExtLinq.True<HrmUserEntity>();
                keyPress = keyPress.And(t => t.PERNR.Contains(keyword));
                keyPress = keyPress.Or(t => t.NACHN.Contains(keyword));
                expression = expression.And(keyPress);
            }
            return Json(new
            {
                rows = userApp.GetList(pagination, expression),
                total = pagination.total

            });
            //var data = new
            //{
            //    rows = userApp.GetList(pagination, expression),
            //    total = pagination.total,
            //    page = pagination.page,
            //    records = pagination.records
            //};
            //return Content(data.ToJson());
        }

        /// <summary>
        /// 移出科室的所有用户数据
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pagination"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(string id, Pagination pagination, string keyword)
        {
            System.Linq.Expressions.Expression<Func<HrmUserEntity, bool>> expression = ExtLinq.True<HrmUserEntity>();
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
            if (!string.IsNullOrEmpty(id) & IsDoctor != "3")
            {
                expression = expression.And(p => p.RYLB == id);
            }
            if (!string.IsNullOrEmpty(keyword))
            {
                var keyPress = ExtLinq.True<HrmUserEntity>();
                keyPress = keyPress.And(t => t.PERNR.Contains(keyword));
                keyPress = keyPress.Or(t => t.NACHN.Contains(keyword));
                expression = expression.And(keyPress);
            }

            var data = new
            {
                rows = userApp.GetList(pagination, expression),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }
        [HttpPost]
        [HandlerAjaxOnly]
        public ActionResult GetGridJsonExport(string id, Pagination pagination, string keyword, string titleAndField)
        {
            System.Linq.Expressions.Expression<Func<View_Hrm_User_OrgEntity, bool>> expression = ExtLinq.True<View_Hrm_User_OrgEntity>();
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
            if (!string.IsNullOrEmpty(id) & IsDoctor != "3")
            {
                expression = expression.And(p => p.RYLB == id);
            }
            if (!string.IsNullOrEmpty(keyword))
            {
                var keyPress = ExtLinq.True<View_Hrm_User_OrgEntity>();
                keyPress = keyPress.And(t => t.PERNR.Contains(keyword));
                keyPress = keyPress.Or(t => t.NACHN.Contains(keyword));
                expression = expression.And(keyPress);
            }


            pagination.page = 1;
            pagination.rows = int.MaxValue;
            var rows = new View_Hrm_User_OrgApp().GetList(pagination, expression);
            titleAndField = titleAndField.Replace("OrganizeId", "F_FullName");//组织使用名称
            var dicFields = HandleTitelAndField.GetTitleAndField(titleAndField, 12, 15, 18);
            var downUrl = NPOIWriteExcel.OutputExcel(rows, dicFields, new ExcelCaption { CaptionName = "科室人员清单表", Height = 24 });

            return Success("下载成功", downUrl);
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJsonForIn(string id, Pagination pagination, string keyword, bool Is_all = false)
        {
            System.Linq.Expressions.Expression<Func<HrmUserEntity, bool>> expression = ExtLinq.True<HrmUserEntity>();

            expression = expression.And(p => string.IsNullOrEmpty(p.OrganizeId));
            if (!string.IsNullOrEmpty(id) & IsDoctor != "3")
            {
                expression = expression.And(p => p.RYLB == id);
            }
            if (!string.IsNullOrEmpty(keyword))
            {
                var keyPress = ExtLinq.True<HrmUserEntity>();
                keyPress = keyPress.And(t => t.PERNR.Contains(keyword));
                keyPress = keyPress.Or(t => t.NACHN.Contains(keyword));
                expression = expression.And(keyPress);
            }
            if (!Is_all)
            {
                expression = expression.And(s => s.STAT2 == "3" || (s.STAT2 == "2" & (s.PERSK == "70" || s.PERSK == "73")));
            }
            var data = new
            {
                rows = userApp.GetList(pagination, expression),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }
        [HttpPost]
        [HandlerAjaxOnly]
        public ActionResult GetGridJsonForInExport(string id, Pagination pagination, string keyword, string titleAndField, bool Is_all = false)
        {
            System.Linq.Expressions.Expression<Func<HrmUserEntity, bool>> expression = ExtLinq.True<HrmUserEntity>();

            expression = expression.And(p => string.IsNullOrEmpty(p.OrganizeId));
            if (!string.IsNullOrEmpty(id) & IsDoctor != "3")
            {
                expression = expression.And(p => p.RYLB == id);
            }
            if (!string.IsNullOrEmpty(keyword))
            {
                var keyPress = ExtLinq.True<HrmUserEntity>();
                keyPress = keyPress.And(t => t.PERNR.Contains(keyword));
                keyPress = keyPress.Or(t => t.NACHN.Contains(keyword));
                expression = expression.And(keyPress);
            }
            if (!Is_all)
            {
                expression = expression.And(s => s.STAT2 == "3" || (s.STAT2 == "2" & (s.PERSK == "70" || s.PERSK == "73")));
            }

            pagination.page = 1;
            pagination.rows = int.MaxValue;
            var rows = userApp.GetList(pagination, expression);

            var dicFields = HandleTitelAndField.GetTitleAndField(titleAndField, 12, 15, 18);
            var downUrl = NPOIWriteExcel.OutputExcel(rows, dicFields, new ExcelCaption { CaptionName = "未分配科室人员表", Height = 24 });

            return Success("下载成功", downUrl);
        }
        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult RemoveUser(string keyValue, string outOrgId, string orgInId)
        {
            var user = userApp.GetForm(keyValue);
            var orgId = user.OrganizeId;
            user.OrganizeId = orgInId ?? "";//没有就默认
            userApp.SubmitForm(user, keyValue);
            AddOutAndInRecord(user, "科室移出", outOrgId);//移出时 增加移出科室
            if (!string.IsNullOrEmpty(orgInId))
            {
                AddOutAndInRecord(user, "科室移入", orgInId);
            }
            return Success("移出成功。");
        }
        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult InUser(string keyValue, string orgId)
        {
            orgId = orgId ?? OperatorProvider.Provider.GetCurrent().CompanyId;//当前用户所在公司ID
            var user = userApp.GetForm(keyValue);
            user.OrganizeId = orgId;
            userApp.SubmitForm(user, keyValue);
            AddOutAndInRecord(user, "科室移入", orgId);

            var time = DateTime.Now;
            var searchTime=time.AddDays(1 - time.Day);//月初
            if (time.Month<=10)
            {
                searchTime = searchTime.AddMonths(-1);//上个月月初
            }
            System.Linq.Expressions.Expression<Func<AskForLeaveEntity, bool>> expression = ExtLinq.True<AskForLeaveEntity>();
            expression = expression.And(p => p.IsNew == true);
            expression = expression.And(p => p.EndDate == null || p.EndDate > searchTime);
            var records = askApp.GetList(new Pagination { page = 1, rows = 100 }, expression);
            foreach(var item in records)//可优化  但数据一般至多一条
            {
                item.OrganizeId = orgId;
                new AskForLeaveApp().SubmitForm(item, item.F_Id);
            }
            return Success("移入成功。");
        }
        /// <summary>
        /// 添加移入和移出的记录
        /// </summary>
        /// <param name="hrmUser">员工</param>
        /// <param name="operateType">操作类型</param>
        private void AddOutAndInRecord(HrmUserEntity hrmUser, string operateType, string OrganizeId)
        {
            OutAndInEntity entity = new OutAndInEntity();
            entity.F_Id = Guid.NewGuid().ToString();
            entity.UserId = hrmUser.F_Id;
            entity.OperateTime = DateTime.Now;
            entity.OperateType = operateType;
            entity.OrganizeId = OrganizeId;
            OutAndInApp app = new OutAndInApp();
            app.SubmitForm(entity, "");//创建移入移出记录
        }
    }
}
