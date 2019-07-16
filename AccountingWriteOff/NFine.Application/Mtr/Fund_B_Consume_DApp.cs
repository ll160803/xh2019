//-----------------------------------------------------------------------
// <copyright file=" Fund_B_Consume_D.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: Fund_B_Consume_D.cs
// * history : Created by T4 07/10/2019 15:15:48 
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
    public class Fund_B_Consume_DApp
    {
		private IFund_B_Consume_DRepository service = new Fund_B_Consume_DRepository();

		public List<Fund_B_Consume_DEntity> GetList(Pagination pagination, string queryJson)
        {
		    var expression = ExtLinq.True<Fund_B_Consume_DEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyword = queryParam["keyword"].ToString();
                expression = expression.And(t => t.Currency.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }
		public List<Fund_B_Consume_DEntity> GetList(Pagination pagination, System.Linq.Expressions.Expression<Func<Fund_B_Consume_DEntity, bool>> expression)
        {
            return service.FindList(expression, pagination);
        }
	    public Fund_B_Consume_DEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(Fund_B_Consume_DEntity entity)
        {
            service.Delete(entity);
        }

		public void SubmitForm(Fund_B_Consume_DEntity entity, string keyValue)
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