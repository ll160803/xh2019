//-----------------------------------------------------------------------
// <copyright file=" MtrFund_MtrType.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: MtrFund_MtrType.cs
// * history : Created by T4 08/16/2019 15:15:31 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain.Entity.Mtr
{
    /// <summary>
    /// MtrFund_MtrType Entity Model
    /// </summary>
    public class MtrFund_MtrTypeEntity : IEntity<MtrFund_MtrTypeEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
						public  string  F_Id { get; set; }
					public  string  F_ItemCode { get; set; }
					public  string  F_ItemName { get; set; }
					public  string  F_IGortCode { get; set; }
					public  string  F_IGortName { get; set; }
					public  string  F_SimpleSpelling { get; set; }
					public  bool?  F_IsDefault { get; set; }
					public  int?  F_Layers { get; set; }
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