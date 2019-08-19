//-----------------------------------------------------------------------
// <copyright file=" MtrFund_MtrType.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: MtrFund_MtrType.cs
// * history : Created by T4 08/16/2019 15:15:30 
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
    public class MtrFund_MtrTypeApp
    {
        private IMtrFund_MtrTypeRepository service = new MtrFund_MtrTypeRepository();

        public List<MtrFund_MtrTypeEntity> GetList(Pagination pagination, string keyword)
        {
            var expression = ExtLinq.True<MtrFund_MtrTypeEntity>();
          
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.F_ItemCode.Contains(keyword));
                expression = expression.Or(t => t.F_ItemName.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }
        public List<MtrFund_MtrTypeEntity> GetList(Pagination pagination, System.Linq.Expressions.Expression<Func<MtrFund_MtrTypeEntity, bool>> expression)
        {
            return service.FindList(expression, pagination);
        }
        public MtrFund_MtrTypeEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(MtrFund_MtrTypeEntity entity)
        {
            service.Delete(entity);
        }

        public void SubmitForm(MtrFund_MtrTypeEntity entity, string keyValue)
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