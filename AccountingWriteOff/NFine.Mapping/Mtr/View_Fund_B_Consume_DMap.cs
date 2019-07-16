//-----------------------------------------------------------------------
// <copyright file=" View_Fund_B_Consume_D.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: View_Fund_B_Consume_D.cs
// * history : Created by T4 07/12/2019 17:05:54 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Domain.Entity.Mtr;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NFine.Mapping.Mtr
{
    public class View_Fund_B_Consume_DMap : EntityTypeConfiguration<View_Fund_B_Consume_DEntity>
    {
		 public View_Fund_B_Consume_DMap()
        {
            this.ToTable("View_Fund_B_Consume_D");
            this.HasKey(t => t.F_Id);
        }
    }
}