//-----------------------------------------------------------------------
// <copyright file=" ViewHrmAttandaceSap.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: ViewHrmAttandaceSap.cs
// * history : Created by T4 07/02/2019 16:27:31 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Domain.Entity.Hrm;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NFine.Mapping.Hrm
{
    public class ViewHrmAttandaceSapMap : EntityTypeConfiguration<ViewHrmAttandaceSapEntity>
    {
		 public ViewHrmAttandaceSapMap()
        {
            this.ToTable("view_hrmattandacesap");
            this.HasKey(t => t.F_Id);
        }
    }
}