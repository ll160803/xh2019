//-----------------------------------------------------------------------
// <copyright file=" AttendanceRecord.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: AttendanceRecord.cs
// * history : Created by T4 06/27/2019 10:48:51 
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
    /// AttendanceRecord Entity Model
    /// </summary>
    public class AttendanceRecordEntity : IEntity<AttendanceRecordEntity>, ICreationAudited, IDeleteAudited, IModificationAudited
    {
        public string F_Id { get; set; }
        public string AttendDate { get; set; }
        public int? State { get; set; }
        public string SubmitMan { get; set; }
        public string AuditMan { get; set; }
        public bool? Flag { get; set; }
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
        public string OrganizeId { get; set; }
        public DateTime? SubmitDate { get; set; }
        public DateTime? AuditDate { get; set; }

    }
}