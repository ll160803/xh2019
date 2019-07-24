//-----------------------------------------------------------------------
// <copyright file=" Mtr_Fund_D_Mtr_History.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: Mtr_Fund_D_Mtr_History.cs
// * history : Created by T4 07/24/2019 14:53:21 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Domain.Entity.Mtr;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NFine.Mapping.Mtr
{
    public class Mtr_Fund_D_Mtr_HistoryMap : EntityTypeConfiguration<Mtr_Fund_D_Mtr_HistoryEntity>
    {
		 public Mtr_Fund_D_Mtr_HistoryMap()
        {
            this.ToTable("MtrFund_D_Mtr_History");
            this.HasKey(t => t.F_Id);
        }
    }
}