//-----------------------------------------------------------------------
// <copyright file=" Fund_B_Consume_D.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: Fund_B_Consume_D.cs
// * history : Created by T4 07/10/2019 15:15:50 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Domain.Entity.Mtr;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NFine.Mapping.Mtr
{
    public class Fund_B_Consume_DMap : EntityTypeConfiguration<Fund_B_Consume_DEntity>
    {
		 public Fund_B_Consume_DMap()
        {
            this.ToTable("Fund_B_Consume_D");
            this.HasKey(t => t.F_Id);
        }
    }
}