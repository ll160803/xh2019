//-----------------------------------------------------------------------
// <copyright file=" Fund_B_Consume.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: Fund_B_Consume.cs
// * history : Created by T4 07/10/2019 15:15:39 
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
    /// Fund_B_Consume Entity Model
    /// </summary>
    public partial class Fund_B_ConsumeEntity : IEntity<Fund_B_ConsumeEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
						public  string  F_Id { get; set; }
        public string Code { get; set; }
        public  string  Werks { get; set; }
					public  string  WerksId { get; set; }
					public  string  Lgort { get; set; }
					public  string  LgortName { get; set; }
					public  string  UserId { get; set; }
					public  string  UserName { get; set; }
					public  string  UserCode { get; set; }
        public string Ref_Code { get; set; }
        public  DateTime?  OperateTime { get; set; }
					public  string  CardNumber { get; set; }
					public  string  FundNumber { get; set; }
					public  string  FundName { get; set; }
					public  decimal?  FundAmount { get; set; }
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