//-----------------------------------------------------------------------
// <copyright file=" HrmUser.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: HrmUser.cs
// * history : Created by T4 06/13/2019 11:15:42 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Data;
using NFine.Domain.Entity.Hrm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain.IRepository.Hrm
{
    public interface IHrmUserRepository : IRepositoryBase<HrmUserEntity>
    {
    }
}