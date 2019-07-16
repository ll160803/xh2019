//-----------------------------------------------------------------------
// <copyright file=" ViewHrmAskForLeaveRecord.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: ViewHrmAskForLeaveRecord.cs
// * history : Created by T4 06/20/2019 15:31:17 
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
    public class ViewHrmAskForLeaveRecordApp
    {
		private IViewHrmAskForLeaveRecordRepository service = new ViewHrmAskForLeaveRecordRepository();

		public List<ViewHrmAskForLeaveRecordEntity> GetList(Pagination pagination, string queryJson)
        {
		    var expression = ExtLinq.True<ViewHrmAskForLeaveRecordEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyword = queryParam["keyword"].ToString();
                expression = expression.And(t => t.F_Description.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }
        public List<ViewHrmAskForLeaveRecordEntity> GetList(Pagination pagination, System.Linq.Expressions.Expression<Func<ViewHrmAskForLeaveRecordEntity,bool>> expression)
        {
            return service.FindList(expression, pagination);
        }
        public ViewHrmAskForLeaveRecordEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(ViewHrmAskForLeaveRecordEntity entity)
        {
            service.Delete(entity);
        }

		public void SubmitForm(ViewHrmAskForLeaveRecordEntity entity, string keyValue)
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