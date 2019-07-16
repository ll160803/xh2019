//-----------------------------------------------------------------------
// <copyright file=" View_Fund_B_Consume_D.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: View_Fund_B_Consume_D.cs
// * history : Created by T4 07/12/2019 17:05:52 
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
    public class View_Fund_B_Consume_DApp
    {
		private IView_Fund_B_Consume_DRepository service = new View_Fund_B_Consume_DRepository();

		public List<View_Fund_B_Consume_DEntity> GetList(Pagination pagination, string queryJson)
        {
		    var expression = ExtLinq.True<View_Fund_B_Consume_DEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyword = queryParam["keyword"].ToString();
                expression = expression.And(t => t.FundName.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }
		public List<View_Fund_B_Consume_DEntity> GetList(Pagination pagination, System.Linq.Expressions.Expression<Func<View_Fund_B_Consume_DEntity, bool>> expression)
        {
            return service.FindList(expression, pagination);
        }
	    public View_Fund_B_Consume_DEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(View_Fund_B_Consume_DEntity entity)
        {
            service.Delete(entity);
        }

		public void SubmitForm(View_Fund_B_Consume_DEntity entity, string keyValue)
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