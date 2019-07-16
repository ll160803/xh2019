//-----------------------------------------------------------------------
// <copyright file=" HistoryRecordDetail.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: HistoryRecordDetail.cs
// * history : Created by T4 06/21/2019 10:22:46 
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
    public class HistoryRecordDetailApp
    {
		private IHistoryRecordDetailRepository service = new HistoryRecordDetailRepository();

		public List<HistoryRecordDetailEntity> GetList(Pagination pagination, string queryJson)
        {
		    var expression = ExtLinq.True<HistoryRecordDetailEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyword = queryParam["keyword"].ToString();
                expression = expression.And(t => t.F_Description.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }
        public List<HistoryRecordDetailEntity> GetList(Pagination pagination, System.Linq.Expressions.Expression<Func<HistoryRecordDetailEntity, bool>> expression)
        {
            return service.FindList(expression, pagination);
        }
        public HistoryRecordDetailEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(HistoryRecordDetailEntity entity)
        {
            service.Delete(entity);
        }

		public void SubmitForm(HistoryRecordDetailEntity entity, string keyValue)
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