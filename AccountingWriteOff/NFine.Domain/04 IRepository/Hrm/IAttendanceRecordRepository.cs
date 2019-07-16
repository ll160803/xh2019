//-----------------------------------------------------------------------
// <copyright file=" AttendanceRecord.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: AttendanceRecord.cs
// * history : Created by T4 06/27/2019 10:48:51 
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
    public interface IAttendanceRecordRepository : IRepositoryBase<AttendanceRecordEntity>
    {
    }
}