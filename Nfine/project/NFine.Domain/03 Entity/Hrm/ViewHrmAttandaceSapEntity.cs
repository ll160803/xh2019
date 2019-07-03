//-----------------------------------------------------------------------
// <copyright file=" ViewHrmAttandaceSap.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: ViewHrmAttandaceSap.cs
// * history : Created by T4 07/02/2019 16:27:30 
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
    /// ViewHrmAttandaceSap Entity Model
    /// </summary>
    public class ViewHrmAttandaceSapEntity : IEntity<ViewHrmAttandaceSapEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
						public  string  AttendDate { get; set; }
					public  string  SubmitMan { get; set; }
					public  DateTime?  SubmitDate { get; set; }
					public  string  AuditMan { get; set; }
					public DateTime?  AuditDate { get; set; }
					public  string  F_Id { get; set; }
					public  string  Note { get; set; }
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
					public  string  OrganizeId { get; set; }
					public  string  Base_Id { get; set; }
					public  string  hrm_user_Id { get; set; }
					public  string  PERNR { get; set; }
					public  string  NACHN { get; set; }
					public  string  F_FullName { get; set; }
					public  string  ParentOrgId { get; set; }
					public  string  ParentOrgName { get; set; }
		    }
}