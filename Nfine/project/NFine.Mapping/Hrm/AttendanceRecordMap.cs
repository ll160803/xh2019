//-----------------------------------------------------------------------
// <copyright file=" AttendanceRecord.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: AttendanceRecord.cs
// * history : Created by T4 06/27/2019 10:48:52 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Domain.Entity.Hrm;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NFine.Mapping.Hrm
{
    public class AttendanceRecordMap : EntityTypeConfiguration<AttendanceRecordEntity>
    {
		 public AttendanceRecordMap()
        {
            this.ToTable("AttendanceRecord");
            this.HasKey(t => t.F_Id);
        }
    }
}