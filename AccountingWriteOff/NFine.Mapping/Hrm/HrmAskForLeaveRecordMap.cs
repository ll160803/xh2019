//-----------------------------------------------------------------------
// <copyright file=" HrmAskForLeaveRecord.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: HrmAskForLeaveRecord.cs
// * history : Created by T4 06/19/2019 15:21:28 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Domain.Entity.Hrm;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NFine.Mapping.Hrm
{
    public class HrmAskForLeaveRecordMap : EntityTypeConfiguration<HrmAskForLeaveRecordEntity>
    {
		 public HrmAskForLeaveRecordMap()
        {
            this.ToTable("Hrm_AskForLeaveRecord");
            this.HasKey(t => t.F_Id);
        }
    }
}