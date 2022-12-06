//-----------------------------------------------------------------------
// <copyright file=" ViewReport.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: ViewReport.cs
// * history : Created by T4 12/23/2021 09:31:30 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Domain.Entity.hrm;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NFine.Mapping.hrm
{
    public class ViewReportMap : EntityTypeConfiguration<ViewReportEntity>
    {
		 public ViewReportMap()
        {
            this.ToTable("ViewReport");
            this.HasKey(t => t.PERNR);
        }
    }
}