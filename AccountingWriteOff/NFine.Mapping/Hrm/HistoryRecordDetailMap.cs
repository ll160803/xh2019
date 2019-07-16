//-----------------------------------------------------------------------
// <copyright file=" HistoryRecordDetail.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: HistoryRecordDetail.cs
// * history : Created by T4 06/21/2019 10:22:47 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Domain.Entity.Hrm;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NFine.Mapping.Hrm
{
    public class HistoryRecordDetailMap : EntityTypeConfiguration<HistoryRecordDetailEntity>
    {
		 public HistoryRecordDetailMap()
        {
            this.ToTable("view_historyrecorddetail");
            this.HasKey(t => t.F_Id);
        }
    }
}