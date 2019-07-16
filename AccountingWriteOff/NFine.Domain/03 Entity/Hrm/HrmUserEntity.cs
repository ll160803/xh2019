//-----------------------------------------------------------------------
// <copyright file=" HrmUser.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: HrmUser.cs
// * history : Created by T4 06/13/2019 11:15:41 
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
    /// HrmUser Entity Model
    /// </summary>
    public class HrmUserEntity : IEntity<HrmUserEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
        public string F_Id { get; set; }
        public string PERNR { get; set; }
        public string NACHN { get; set; }
        public string WERKS { get; set; }
        public string NAME1 { get; set; }
        public string BTRTL { get; set; }
        public string BTEXT { get; set; }
        public string ZHRBTRTL { get; set; }
        public string ZHRBTTXT { get; set; }
        public string PERSG { get; set; }
        public string PTEXT { get; set; }
        public string PERSK { get; set; }
        public string PKEXT { get; set; }
        public string GESCH { get; set; }
        public string GESCTXT { get; set; }
        public DateTime? GBDAT { get; set; }
        public string YGGH { get; set; }
        public string RYLB { get; set; }
        public string STAT2 { get; set; }
        public string OrganizeId { get; set; }
        public int? F_SortCode { get; set; }
        public DateTime? ZCGKSRQ { get; set; }
        public DateTime? ZCGJSRQ { get; set; }
        public string ZCGBZ { get; set; }
        public DateTime? ZTQJSRQ { get; set; }
        public DateTime? ZTQKSRQ { get; set; }
        public string ZTQBZ { get; set; }
        public bool? F_DeleteMark { get; set; }
        public bool? F_EnabledMark { get; set; }
        public string F_Description { get; set; }
        public DateTime? F_CreatorTime { get; set; }
        public string F_CreatorUserId { get; set; }
        public DateTime? F_LastModifyTime { get; set; }
        public string F_LastModifyUserId { get; set; }
        public DateTime? F_DeleteTime { get; set; }
        public string F_DeleteUserId { get; set; }

        public string STATXT { get; set; }
    }
}