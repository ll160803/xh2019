//-----------------------------------------------------------------------
// <copyright file=" AskForLeave.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: AskForLeave.cs
// * history : Created by T4 06/14/2019 11:13:25 
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
    /// AskForLeave Entity Model
    /// </summary>
    public class AskForLeaveEntity : IEntity<AskForLeaveEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
						public  string  F_Id { get; set; }
					public  string  HrmUserId { get; set; }
					public  string  OrganizeId { get; set; }
					public  string  AskTypeId { get; set; }
					public  DateTime?  StartDate { get; set; }
					public  DateTime?  EndDate { get; set; }
					public  string  HosOrganize { get; set; }
					public  string  SickCheck { get; set; }
					public  string  State { get; set; }
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
		    }
}