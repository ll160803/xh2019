//-----------------------------------------------------------------------
// <copyright file=" ViewOutAndIn.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: ViewOutAndIn.cs
// * history : Created by T4 06/14/2019 10:13:43 
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
    /// ViewOutAndIn Entity Model
    /// </summary>
    public class ViewOutAndInEntity : IEntity<ViewOutAndInEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
						public  string  F_Id { get; set; }
					public  string  UserId { get; set; }
					public  DateTime?  OperateTime { get; set; }
					public  string  OperateType { get; set; }
					public  string  OrganizeId { get; set; }
					public  string  F_FullName { get; set; }
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