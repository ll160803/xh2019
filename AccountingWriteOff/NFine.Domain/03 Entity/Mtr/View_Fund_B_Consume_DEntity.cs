//-----------------------------------------------------------------------
// <copyright file=" View_Fund_B_Consume_D.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: View_Fund_B_Consume_D.cs
// * history : Created by T4 07/12/2019 17:05:53 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain.Entity.Mtr
{
    /// <summary>
    /// View_Fund_B_Consume_D Entity Model
    /// </summary>
    public class View_Fund_B_Consume_DEntity : IEntity<View_Fund_B_Consume_DEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
        public string F_Id { get; set; }
        public string user_Id { get; set; }
        public string Base_Id { get; set; }
        public string FPHM { get; set; }
        public string Mtr_Id { get; set; }
        public string Mtr_Name { get; set; }
        public string Mtr_Spec { get; set; }
        public string Mtr_UnitName { get; set; }
        public string Mtr_Price { get; set; }
        public string AbbreviationName { get; set; }
        public string Code { get; set; }
        public string ItemCode { get; set; }

        public string num { get; set; }
        public string Money { get; set; }
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
        public string Werks { get; set; }
        public string WerksId { get; set; }
        public string Lgort { get; set; }
        public string LgortName { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserCode { get; set; }
        public DateTime? OperateTime { get; set; }
        public string CardNumber { get; set; }
        public string FundNumber { get; set; }
        public string FundName { get; set; }
        public string FundAmount { get; set; }
    }
}