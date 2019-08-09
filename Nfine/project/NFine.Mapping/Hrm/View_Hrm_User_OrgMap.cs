//-----------------------------------------------------------------------
// <copyright file=" View_Hrm_User_Org.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: View_Hrm_User_Org.cs
// * history : Created by T4 08/06/2019 11:18:58 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Domain.Entity.Hrm;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NFine.Mapping.Hrm
{
    public class View_Hrm_User_OrgMap : EntityTypeConfiguration<View_Hrm_User_OrgEntity>
    {
		 public View_Hrm_User_OrgMap()
        {
            this.ToTable("View_HrmUser_Org");
            this.HasKey(t => t.F_Id);
        }
    }
}