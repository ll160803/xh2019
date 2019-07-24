//-----------------------------------------------------------------------
// <copyright file=" Mtr_Fund_D_Mtr_History.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: Mtr_Fund_D_Mtr_History.cs
// * history : Created by T4 07/24/2019 14:53:20 
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
    /// Mtr_Fund_D_Mtr_History Entity Model
    /// </summary>
    public class Mtr_Fund_D_Mtr_HistoryEntity : IEntity<Mtr_Fund_D_Mtr_HistoryEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
						public  string  F_Id { get; set; }
					public  string  Ref_Id { get; set; }
					public  string  Name { get; set; }
					public  string  Code { get; set; }
					public  string  Spec { get; set; }
					public  string  TypeName { get; set; }
					public  string  UnitName { get; set; }
					public  string  UnitId { get; set; }
					public  string  TypeId { get; set; }
					public  string  Price { get; set; }
					public  string  StockId { get; set; }
					public  string  StockName { get; set; }
					public  string  AbbreviationName { get; set; }
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