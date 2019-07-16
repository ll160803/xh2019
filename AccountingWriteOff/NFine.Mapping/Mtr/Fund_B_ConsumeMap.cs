//-----------------------------------------------------------------------
// <copyright file=" Fund_B_Consume.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: Fund_B_Consume.cs
// * history : Created by T4 07/10/2019 15:15:41 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Domain.Entity.Mtr;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NFine.Mapping.Mtr
{
    public class Fund_B_ConsumeMap : EntityTypeConfiguration<Fund_B_ConsumeEntity>
    {
		 public Fund_B_ConsumeMap()
        {
            this.ToTable("Fund_B_Consume");
            this.HasKey(t => t.F_Id);
        }
    }
}