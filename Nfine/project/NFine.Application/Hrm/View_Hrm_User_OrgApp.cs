//-----------------------------------------------------------------------
// <copyright file=" View_Hrm_User_Org.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: View_Hrm_User_Org.cs
// * history : Created by T4 08/06/2019 11:18:57 
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
    public class View_Hrm_User_OrgApp
    {
		private IView_Hrm_User_OrgRepository service = new View_Hrm_User_OrgRepository();

		public List<View_Hrm_User_OrgEntity> GetList(Pagination pagination, string queryJson)
        {
		    var expression = ExtLinq.True<View_Hrm_User_OrgEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyword = queryParam["keyword"].ToString();
                expression = expression.And(t => t.GESCTXT.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }
		public List<View_Hrm_User_OrgEntity> GetList(Pagination pagination, System.Linq.Expressions.Expression<Func<View_Hrm_User_OrgEntity, bool>> expression)
        {
            return service.FindList(expression, pagination);
        }
	    public View_Hrm_User_OrgEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(View_Hrm_User_OrgEntity entity)
        {
            service.Delete(entity);
        }

		public void SubmitForm(View_Hrm_User_OrgEntity entity, string keyValue)
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