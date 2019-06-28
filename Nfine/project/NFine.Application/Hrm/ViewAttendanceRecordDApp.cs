//-----------------------------------------------------------------------
// <copyright file=" ViewAttendanceRecordD.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: ViewAttendanceRecordD.cs
// * history : Created by T4 06/27/2019 17:04:11 
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
    public class ViewAttendanceRecordDApp
    {
		private IViewAttendanceRecordDRepository service = new ViewAttendanceRecordDRepository();

		public List<ViewAttendanceRecordDEntity> GetList(Pagination pagination, string queryJson)
        {
		    var expression = ExtLinq.True<ViewAttendanceRecordDEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyword = queryParam["keyword"].ToString();
                expression = expression.And(t => t.F_Description.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }
        public List<ViewAttendanceRecordDEntity> GetList(Pagination pagination, System.Linq.Expressions.Expression<Func<ViewAttendanceRecordDEntity, bool>> expression)
        {

            //var expression = ExtLinq.True<HrmUserEntity>();


            return service.FindList(expression, pagination);
        }
        public ViewAttendanceRecordDEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(ViewAttendanceRecordDEntity entity)
        {
            service.Delete(entity);
        }

		public void SubmitForm(ViewAttendanceRecordDEntity entity, string keyValue)
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