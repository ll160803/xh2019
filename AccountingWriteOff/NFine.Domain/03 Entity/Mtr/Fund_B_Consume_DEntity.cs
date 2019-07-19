//-----------------------------------------------------------------------
// <copyright file=" Fund_B_Consume_D.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: Fund_B_Consume_D.cs
// * history : Created by T4 07/10/2019 15:15:49 
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
    /// Fund_B_Consume_D Entity Model
    /// </summary>
    public class Fund_B_Consume_DEntity : IEntity<Fund_B_Consume_DEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
        public string F_Id { get; set; }
        public string Base_Id { get; set; }
        public string ItemCode { get; set; }
        public string FPHM { get; set; }
        public string Mtr_Id { get; set; }
        public string Mtr_Name { get; set; }
        public string Mtr_Spec { get; set; }
        public string Mtr_UnitName { get; set; }
        public string Mtr_TypeName { get; set; }
       
        
        public string Mtr_TypeCode { get; set; }
        public decimal? Mtr_Price { get; set; }
        public decimal? num { get; set; }
        public decimal? Money { get; set; }
        public string Currency { get; set; }
        public bool? Is_New { get; set; }
        public bool? F_AllowEdit { get; set; }
        public bool? F_AllowDelete { get; set; }
        public int? F_SortCode { get; set; }
        public bool? F_DeleteMark { get; set; }
        public bool? F_EnabledMark { get; set; }
        public string F_Description { get; set; }
        public DateTime? F_CreatorTime { get; set; }
        public string F_CreatorUserId { get; set; }
        public DateTime? F_LastModifyTime { get; set; }
        public string F_LastModifyUserId { get; set; }
        public DateTime? F_DeleteTime { get; set; }
        public string F_DeleteUserId { get; set; }
    }
}