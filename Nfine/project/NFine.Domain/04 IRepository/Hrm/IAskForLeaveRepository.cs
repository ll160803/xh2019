//-----------------------------------------------------------------------
// <copyright file=" AskForLeave.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: AskForLeave.cs
// * history : Created by T4 06/14/2019 11:13:26 
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
    public interface IAskForLeaveRepository : IRepositoryBase<AskForLeaveEntity>
    {
        List<AskForLeaveEntity> GetItemList(System.DateTime startTime, System.DateTime endTime, string userId,string keyValue);
    }
}