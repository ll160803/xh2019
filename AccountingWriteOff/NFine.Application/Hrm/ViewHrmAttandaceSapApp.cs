//-----------------------------------------------------------------------
// <copyright file=" ViewHrmAttandaceSap.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: ViewHrmAttandaceSap.cs
// * history : Created by T4 07/02/2019 16:27:29 
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
    public class ViewHrmAttandaceSapApp
    {
        private IViewHrmAttandaceSapRepository service = new ViewHrmAttandaceSapRepository();

        public List<ViewHrmAttandaceSapEntity> GetList(Pagination pagination, string queryJson)
        {
            var expression = ExtLinq.True<ViewHrmAttandaceSapEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyword = queryParam["keyword"].ToString();
                expression = expression.And(t => t.Note.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }
        public List<ViewHrmAttandaceSapEntity> GetList(Pagination pagination, System.Linq.Expressions.Expression<Func<ViewHrmAttandaceSapEntity, bool>> expression)
        {

            //var expression = ExtLinq.True<HrmUserEntity>();


            return service.FindList(expression, pagination);
        }
        public ViewHrmAttandaceSapEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(ViewHrmAttandaceSapEntity entity)
        {
            service.Delete(entity);
        }

        public void SubmitForm(ViewHrmAttandaceSapEntity entity, string keyValue)
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