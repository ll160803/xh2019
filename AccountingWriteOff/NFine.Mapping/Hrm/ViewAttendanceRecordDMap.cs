//-----------------------------------------------------------------------
// <copyright file=" ViewAttendanceRecordD.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: ViewAttendanceRecordD.cs
// * history : Created by T4 06/27/2019 17:04:13 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Domain.Entity.Hrm;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NFine.Mapping.Hrm
{
    public class ViewAttendanceRecordDMap : EntityTypeConfiguration<ViewAttendanceRecordDEntity>
    {
		 public ViewAttendanceRecordDMap()
        {
            this.ToTable("View_AttendanceRecord_D");
            this.HasKey(t => t.F_Id);
        }
    }
}