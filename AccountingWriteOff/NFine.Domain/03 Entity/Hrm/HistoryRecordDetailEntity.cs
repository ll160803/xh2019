//-----------------------------------------------------------------------
// <copyright file=" HistoryRecordDetail.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: HistoryRecordDetail.cs
// * history : Created by T4 06/21/2019 10:22:46 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain.Entity.Hrm
{
    /// <summary>
    /// HistoryRecordDetail Entity Model
    /// </summary>
    public partial class HistoryRecordDetailEntity : IEntity<HistoryRecordDetailEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
						public  string  Base_Id { get; set; }
					public  string  F_Id { get; set; }
					public  bool?  Flag { get; set; }
					public  string  Ref_Id { get; set; }
					public  string  HrmUserId { get; set; }
					public  string  OrganizeId { get; set; }
					public  string  AskTypeId { get; set; }
					public  DateTime?  StartDate { get; set; }
					public  DateTime?  EndDate { get; set; }
					public  string  HosOrganize { get; set; }
					public  string  SickCheck { get; set; }
					public  int?  State { get; set; }
					public  string  SubmitUser { get; set; }
					public  string  LeaderAudit { get; set; }
					public  DateTime?  LeaderAuditTime { get; set; }
					public  string  LastAudit { get; set; }
					public  DateTime?  LastAuditTime { get; set; }
					public  bool?  F_AllowEdit { get; set; }
					public  bool?  F_AllowDelete { get; set; }
					public  int?  F_SortCode { get; set; }
					public  bool?  F_DeleteMark { get; set; }
					public  bool?  F_EnabledMark { get; set; }
					public  string  F_Description { get; set; }
					public  DateTime?  F_CreatorTime { get; set; }
					public  string  F_CreatorUserId { get; set; }
					public  DateTime?  F_LastModifyTime { get; set; }
					public  string  F_LastModifyUserId { get; set; }
					public  DateTime?  F_DeleteTime { get; set; }
					public  string  F_DeleteUserId { get; set; }
					public  int?  AskSort { get; set; }
					public  bool?  IsNew { get; set; }
					public  string  PERNR { get; set; }
					public  string  NACHN { get; set; }
					public  string  WERKS { get; set; }
					public  string  NAME1 { get; set; }
					public  string  BTRTL { get; set; }
					public  string  BTEXT { get; set; }
					public  string  ZHRBTRTL { get; set; }
					public  string  ZHRBTTXT { get; set; }
					public  string  PERSG { get; set; }
					public  string  PTEXT { get; set; }
					public  string  PERSK { get; set; }
					public  string  PKEXT { get; set; }
					public  string  GESCH { get; set; }
					public  string  GESCTXT { get; set; }
					public  DateTime?  GBDAT { get; set; }
					public  string  YGGH { get; set; }
					public  string  RYLB { get; set; }
					public  string  STAT2 { get; set; }
					public  string  F_FullName { get; set; }
					public  string  F_ItemName { get; set; }
					public  string  Suggestion { get; set; }
		    }
}