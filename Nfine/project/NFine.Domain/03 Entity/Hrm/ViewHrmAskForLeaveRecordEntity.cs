//-----------------------------------------------------------------------
// <copyright file=" ViewHrmAskForLeaveRecord.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: ViewHrmAskForLeaveRecord.cs
// * history : Created by T4 06/20/2019 15:31:17 
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
    /// ViewHrmAskForLeaveRecord Entity Model
    /// </summary>
    public class ViewHrmAskForLeaveRecordEntity : IEntity<ViewHrmAskForLeaveRecordEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
						public  string  F_Id { get; set; }
					public  string  OragnizeId { get; set; }
					public  string  OragnizeName { get; set; }
					public  string  UserId { get; set; }
					public  bool?  Flag { get; set; }
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
					public  string  F_RealName { get; set; }
					public  string  F_FullName { get; set; }
		    }
}