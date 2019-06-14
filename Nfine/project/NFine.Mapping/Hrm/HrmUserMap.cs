//-----------------------------------------------------------------------
// <copyright file=" HrmUser.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: HrmUser.cs
// * history : Created by T4 06/13/2019 11:15:42 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Domain.Entity.Hrm;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NFine.Mapping.Hrm
{
    public class HrmUserMap : EntityTypeConfiguration<HrmUserEntity>
    {
		 public HrmUserMap()
        {
            this.ToTable("Hrm_User");
            this.HasKey(t => t.F_Id);
        }
    }
}