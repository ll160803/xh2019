//-----------------------------------------------------------------------
// <copyright file=" AttendanceRecord.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: AttendanceRecord.cs
// * history : Created by T4 06/27/2019 10:48:52 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Data;
using NFine.Domain.Entity.Hrm;
using NFine.Domain.IRepository.Hrm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Repository.Hrm
{
    public class AttendanceRecordRepository : RepositoryBase<AttendanceRecordEntity>, IAttendanceRecordRepository
    {
    }
}