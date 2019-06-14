//-----------------------------------------------------------------------
// <copyright file=" OutAndIn.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: OutAndIn.cs
// * history : Created by T4 06/14/2019 08:48:29 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Domain.Entity.Hrm;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NFine.Mapping.Hrm
{
    public class OutAndInMap : EntityTypeConfiguration<OutAndInEntity>
    {
		 public OutAndInMap()
        {
            this.ToTable("hrm_outandin");
            this.HasKey(t => t.F_Id);
        }
    }
}