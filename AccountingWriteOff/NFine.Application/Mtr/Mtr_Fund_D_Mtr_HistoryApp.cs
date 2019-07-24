//-----------------------------------------------------------------------
// <copyright file=" Mtr_Fund_D_Mtr_History.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: Mtr_Fund_D_Mtr_History.cs
// * history : Created by T4 07/24/2019 14:53:19 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Code;
using NFine.Domain.Entity.Mtr;
using NFine.Domain.IRepository.Mtr;
using NFine.Repository.Mtr;
using System;
using System.Collections.Generic;
using System.Linq;
namespace NFine.Application.Mtr
{
    public class Mtr_Fund_D_Mtr_HistoryApp
    {
		private IMtr_Fund_D_Mtr_HistoryRepository service = new Mtr_Fund_D_Mtr_HistoryRepository();

		public List<Mtr_Fund_D_Mtr_HistoryEntity> GetList(Pagination pagination, string queryJson)
        {
		    var expression = ExtLinq.True<Mtr_Fund_D_Mtr_HistoryEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyword = queryParam["keyword"].ToString();
                expression = expression.And(t => t.Code.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }
		public List<Mtr_Fund_D_Mtr_HistoryEntity> GetList(Pagination pagination, System.Linq.Expressions.Expression<Func<Mtr_Fund_D_Mtr_HistoryEntity, bool>> expression)
        {
            return service.FindList(expression, pagination);
        }
	    public Mtr_Fund_D_Mtr_HistoryEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(Mtr_Fund_D_Mtr_HistoryEntity entity)
        {
            service.Delete(entity);
        }

		public void SubmitForm(Mtr_Fund_D_Mtr_HistoryEntity entity, string keyValue)
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