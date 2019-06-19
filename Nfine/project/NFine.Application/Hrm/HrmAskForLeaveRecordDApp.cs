//-----------------------------------------------------------------------
// <copyright file=" HrmAskForLeaveRecordD.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: HrmAskForLeaveRecordD.cs
// * history : Created by T4 06/19/2019 15:21:39 
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
    public class HrmAskForLeaveRecordDApp
    {
		private IHrmAskForLeaveRecordDRepository service = new HrmAskForLeaveRecordDRepository();

		public List<HrmAskForLeaveRecordDEntity> GetList(Pagination pagination, string queryJson)
        {
		    var expression = ExtLinq.True<HrmAskForLeaveRecordDEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyword = queryParam["keyword"].ToString();
                expression = expression.And(t => t.F_Id.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }

	    public HrmAskForLeaveRecordDEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(HrmAskForLeaveRecordDEntity entity)
        {
            service.Delete(entity);
        }

		public void SubmitForm(HrmAskForLeaveRecordDEntity entity, string keyValue)
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