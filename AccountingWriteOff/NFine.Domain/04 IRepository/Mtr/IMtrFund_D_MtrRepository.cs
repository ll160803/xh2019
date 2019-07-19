//-----------------------------------------------------------------------
// <copyright file=" MtrFund_D_Mtr.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: MtrFund_D_Mtr.cs
// * history : Created by T4 07/09/2019 16:02:46 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Data;
using NFine.Domain.Entity.Mtr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain.IRepository.Mtr
{
    public interface IMtrFund_D_MtrRepository : IRepositoryBase<MtrFund_D_MtrEntity>
    {
        int UpdatePrice(string keyValue, decimal price);
    }
}