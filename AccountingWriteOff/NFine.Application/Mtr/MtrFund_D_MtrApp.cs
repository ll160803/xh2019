//-----------------------------------------------------------------------
// <copyright file=" MtrFund_D_Mtr.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: MtrFund_D_Mtr.cs
// * history : Created by T4 07/09/2019 16:02:45 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Code;
using NFine.Domain.Entity.Mtr;
using NFine.Domain.IRepository.Mtr;
using NFine.Repository.Mtr;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
namespace NFine.Application.Mtr
{
    public class MtrFund_D_MtrApp
    {
        private IMtrFund_D_MtrRepository service = new MtrFund_D_MtrRepository();

        public List<MtrFund_D_MtrEntity> GetList(Pagination pagination, string queryJson)
        {
            var expression = ExtLinq.True<MtrFund_D_MtrEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyword = queryParam["keyword"].ToString();
                expression = expression.And(t => t.Name.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }
        public List<MtrFund_D_MtrEntity> GetList(Pagination pagination, System.Linq.Expressions.Expression<Func<MtrFund_D_MtrEntity, bool>> expression)
        {
            return service.FindList(expression, pagination);
        }
        public MtrFund_D_MtrEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(MtrFund_D_MtrEntity entity)
        {
            service.Delete(entity);
        }
        public void Update(decimal price, string keyValue)
        {
            service.UpdatePrice(keyValue, price);
        }
        public string GetMaxCode()
        {
            string maxCode = new Data.RepositoryBase<MtrFund_D_MtrEntity>().Max(ExtLinq.True<MtrFund_D_MtrEntity>(), p => p.F_Id);
            if (string.IsNullOrEmpty(maxCode))
            {
                maxCode = DateTime.Now.ToString("yyyy") + "000001";
            }
            else
            {
                int num = int.Parse(maxCode.Substring(4, 6)) + 1;
                maxCode = maxCode.Substring(0, 4) + num.ToString().PadLeft(6, '0');
            }
            return maxCode;
        }
        public void SubmitForm(MtrFund_D_MtrEntity entity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                entity.Modify(keyValue);
                service.Update(entity);
            }
            else
            {
                entity.F_Id = GetMaxCode();
               // entity.Code = GetMaxCode();
                entity.Create();
                service.Insert(entity);
            }
        }
        public bool IsExist(MtrFund_D_MtrEntity entity, string keyValue)
        {
            var list = new List<MtrFund_D_MtrEntity>();
            if (string.IsNullOrEmpty(keyValue))
            {
                list = service.FindList(t => t.Name == entity.Name.Trim() & t.Spec == entity.Spec.Trim(), new Pagination { page = 1, rows = 2, sidx = "Name", sord = "asc" });
            }
            else
            {
                list = service.FindList(t => t.Name == entity.Name.Trim() & t.Spec == entity.Spec.Trim() & t.F_Id != keyValue, new Pagination { page = 1, rows = 2, sidx = "Name", sord = "asc" });
            }
            if (list.Count > 0)
                return false;
            return true;
        }
    }
}