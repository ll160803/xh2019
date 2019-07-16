//-----------------------------------------------------------------------
// <copyright file=" OutAndIn.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: OutAndIn.cs
// * history : Created by T4 06/14/2019 08:48:28 
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
    public class OutAndInApp
    {
		private IOutAndInRepository service = new OutAndInRepository();

		public List<OutAndInEntity> GetList(Pagination pagination, string queryJson)
        {
		    var expression = ExtLinq.True<OutAndInEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyword = queryParam["keyword"].ToString();
                expression = expression.And(t => t.OperateType.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }

	    public OutAndInEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(OutAndInEntity entity)
        {
            service.Delete(entity);
        }

		public void SubmitForm(OutAndInEntity entity, string keyValue)
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