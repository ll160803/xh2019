//-----------------------------------------------------------------------
// <copyright file=" ViewOutAndIn.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: ViewOutAndIn.cs
// * history : Created by T4 06/14/2019 10:02:51 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Domain.Entity.Hrm;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NFine.Mapping.Hrm
{
    public class ViewOutAndInMap : EntityTypeConfiguration<ViewOutAndInEntity>
    {
		 public ViewOutAndInMap()
        {
            this.ToTable("View_OutAndIn");
            this.HasKey(t => t.F_Id);
        }
    }
}