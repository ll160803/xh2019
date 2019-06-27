//-----------------------------------------------------------------------
// <copyright file=" AttendanceRecord.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: AttendanceRecord.cs
// * history : Created by T4 06/27/2019 10:48:50 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Code;
using NFine.Domain.Entity.Hrm;
using NFine.Domain.IRepository.Hrm;
using NFine.Repository.Hrm;
using System;
using System.Collections.Generic;
using System.Linq;
namespace NFine.Application.Hrm
{
    public class AttendanceRecordApp
    {
		private IAttendanceRecordRepository service = new AttendanceRecordRepository();

		public List<AttendanceRecordEntity> GetList(Pagination pagination, string queryJson)
        {
		    var expression = ExtLinq.True<AttendanceRecordEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyword = queryParam["keyword"].ToString();
                expression = expression.And(t => t.F_Description.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }

	    public AttendanceRecordEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(AttendanceRecordEntity entity)
        {
            service.Delete(entity);
        }

		public void SubmitForm(AttendanceRecordEntity entity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                entity.Modify(keyValue);
                service.Update(entity);
            }
            else
            {
                entity.Create();
                service.Insert(entity);
            }
        }
    }
}