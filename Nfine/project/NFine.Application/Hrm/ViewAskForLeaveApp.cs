//-----------------------------------------------------------------------
// <copyright file=" ViewAskForLeave.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: ViewAskForLeave.cs
// * history : Created by T4 06/14/2019 11:29:18 
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
    public class ViewAskForLeaveApp
    {
		private IViewAskForLeaveRepository service = new ViewAskForLeaveRepository();

		//public List<ViewAskForLeaveEntity> GetList(Pagination pagination, string queryJson)
  //      {
		//    var expression = ExtLinq.True<ViewAskForLeaveEntity>();
  //          var queryParam = queryJson.ToJObject();
  //          if (!queryParam["keyword"].IsEmpty())
  //          {
  //              string keyword = queryParam["keyword"].ToString();
  //              expression = expression.And(t => t..Contains(keyword));
  //          }
  //          return service.FindList(expression, pagination);
  //      }
        public List<ViewAskForLeaveEntity> GetList(Pagination pagination, System.Linq.Expressions.Expression<Func<ViewAskForLeaveEntity, bool>> expression)
        {

            //var expression = ExtLinq.True<HrmUserEntity>();


            return service.FindList(expression, pagination);
        }
        public ViewAskForLeaveEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(ViewAskForLeaveEntity entity)
        {
            service.Delete(entity);
        }

		public void SubmitForm(ViewAskForLeaveEntity entity, string keyValue)
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