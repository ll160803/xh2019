//-----------------------------------------------------------------------
// <copyright file=" ViewAskForLeave.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: ViewAskForLeave.cs
// * history : Created by T4 06/14/2019 11:29:19 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Domain.Entity.Hrm;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NFine.Mapping.Hrm
{
    public class ViewAskForLeaveMap : EntityTypeConfiguration<ViewAskForLeaveEntity>
    {
		 public ViewAskForLeaveMap()
        {
            this.ToTable("View_AskForLeave");
            this.HasKey(t => t.F_Id);
        }
    }
}