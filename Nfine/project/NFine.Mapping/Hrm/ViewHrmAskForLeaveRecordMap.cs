//-----------------------------------------------------------------------
// <copyright file=" ViewHrmAskForLeaveRecord.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: ViewHrmAskForLeaveRecord.cs
// * history : Created by T4 06/20/2019 15:31:18 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Domain.Entity.Hrm;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NFine.Mapping.Hrm
{
    public class ViewHrmAskForLeaveRecordMap : EntityTypeConfiguration<ViewHrmAskForLeaveRecordEntity>
    {
		 public ViewHrmAskForLeaveRecordMap()
        {
            this.ToTable("View_HrmAskForLeaveRecord");
            this.HasKey(t => t.F_Id);
        }
    }
}