//-----------------------------------------------------------------------
// <copyright file=" MtrFund_D_Mtr.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: MtrFund_D_Mtr.cs
// * history : Created by T4 07/09/2019 16:02:47 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Domain.Entity.Mtr;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NFine.Mapping.Mtr
{
    public class MtrFund_D_MtrMap : EntityTypeConfiguration<MtrFund_D_MtrEntity>
    {
		 public MtrFund_D_MtrMap()
        {
            this.ToTable("MtrFund_D_Mtr");
            this.HasKey(t => t.F_Id);
        }
    }
}