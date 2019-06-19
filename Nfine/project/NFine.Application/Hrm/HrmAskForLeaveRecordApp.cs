//-----------------------------------------------------------------------
// <copyright file=" HrmAskForLeaveRecord.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: HrmAskForLeaveRecord.cs
// * history : Created by T4 06/19/2019 15:21:27 
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
    public class HrmAskForLeaveRecordApp
    {
		private IHrmAskForLeaveRecordRepository service = new HrmAskForLeaveRecordRepository();

		public List<HrmAskForLeaveRecordEntity> GetList(Pagination pagination, string queryJson)
        {
		    var expression = ExtLinq.True<HrmAskForLeaveRecordEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyword = queryParam["keyword"].ToString();
                expression = expression.And(t => t.F_Id.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }

	    public HrmAskForLeaveRecordEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(HrmAskForLeaveRecordEntity entity)
        {
            service.Delete(entity);
        }

		public void SubmitForm(HrmAskForLeaveRecordEntity entity, string keyValue)
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