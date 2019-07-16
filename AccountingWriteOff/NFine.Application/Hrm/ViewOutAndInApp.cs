//-----------------------------------------------------------------------
// <copyright file=" ViewOutAndIn.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: ViewOutAndIn.cs
// * history : Created by T4 06/14/2019 10:02:49 
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
    public class ViewOutAndInApp
    {
        private IViewOutAndInRepository service = new ViewOutAndInRepository();

        //public List<ViewOutAndInEntity> GetList(Pagination pagination, string queryJson)
        //      {
        //    var expression = ExtLinq.True<ViewOutAndInEntity>();
        //          var queryParam = queryJson.ToJObject();
        //          if (!queryParam["keyword"].IsEmpty())
        //          {
        //              string keyword = queryParam["keyword"].ToString();
        //              expression = expression.And(t => t.Title.Contains(keyword));
        //          }
        //          return service.FindList(expression, pagination);
        //      }
        public List<ViewOutAndInEntity> GetList(Pagination pagination, System.Linq.Expressions.Expression<Func<ViewOutAndInEntity, bool>> expression)
        {

            //var expression = ExtLinq.True<HrmUserEntity>();


            return service.FindList(expression, pagination);
        }

        public ViewOutAndInEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(ViewOutAndInEntity entity)
        {
            service.Delete(entity);
        }

        public void SubmitForm(ViewOutAndInEntity entity, string keyValue)
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