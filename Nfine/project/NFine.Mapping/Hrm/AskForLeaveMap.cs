//-----------------------------------------------------------------------
// <copyright file=" AskForLeave.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: AskForLeave.cs
// * history : Created by T4 06/14/2019 11:13:26 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Domain.Entity.Hrm;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NFine.Mapping.Hrm
{
    public class AskForLeaveMap : EntityTypeConfiguration<AskForLeaveEntity>
    {
		 public AskForLeaveMap()
        {
            this.ToTable("hrm_AskForLeave");
            this.HasKey(t => t.F_Id);
        }
    }
}