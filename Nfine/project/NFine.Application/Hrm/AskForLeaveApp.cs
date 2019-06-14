//-----------------------------------------------------------------------
// <copyright file=" AskForLeave.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: AskForLeave.cs
// * history : Created by T4 06/14/2019 11:13:25 
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
    public class AskForLeaveApp
    {
		private IAskForLeaveRepository service = new AskForLeaveRepository();

		public List<AskForLeaveEntity> GetList(Pagination pagination, string queryJson)
        {
		    var expression = ExtLinq.True<AskForLeaveEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyword = queryParam["keyword"].ToString();
                expression = expression.And(t => t.HrmUserId.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }

	    public AskForLeaveEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(AskForLeaveEntity entity)
        {
            service.Delete(entity);
        }

		public void SubmitForm(AskForLeaveEntity entity, string keyValue)
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