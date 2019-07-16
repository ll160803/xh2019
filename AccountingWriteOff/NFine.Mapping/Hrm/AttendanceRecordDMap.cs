//-----------------------------------------------------------------------
// <copyright file=" AttendanceRecordD.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: AttendanceRecordD.cs
// * history : Created by T4 06/27/2019 17:02:22 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Domain.Entity.Hrm;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NFine.Mapping.Hrm
{
    public class AttendanceRecordDMap : EntityTypeConfiguration<AttendanceRecordDEntity>
    {
		 public AttendanceRecordDMap()
        {
            this.ToTable("Hrm_AttendanceRecord_D");
            this.HasKey(t => t.F_Id);
        }
    }
}