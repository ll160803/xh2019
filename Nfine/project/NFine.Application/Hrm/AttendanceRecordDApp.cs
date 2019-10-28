//-----------------------------------------------------------------------
// <copyright file=" AttendanceRecordD.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: AttendanceRecordD.cs
// * history : Created by T4 06/27/2019 10:49:07 
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
    public class AttendanceRecordDApp
    {
        private IAttendanceRecordDRepository service = new AttendanceRecordDRepository();

        public List<AttendanceRecordDEntity> GetList(Pagination pagination, string queryJson)
        {
            var expression = ExtLinq.True<AttendanceRecordDEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyword = queryParam["keyword"].ToString();
                expression = expression.And(t => t.F_Description.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }

        public AttendanceRecordDEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(AttendanceRecordDEntity entity)
        {
            service.Delete(entity);
        }

        public void Delete(string base_id)
        {
            var expression = ExtLinq.True<AttendanceRecordDEntity>();
            expression = expression.And(t => t.Base_Id == base_id);
            service.Delete(expression);
        }

        public void SubmitForm(AttendanceRecordDEntity entity, string keyValue)
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
        public void InsertForm(List<AttendanceRecordDEntity> list)
        {
            service.Insert(list);
        }
    }
}