//-----------------------------------------------------------------------
// <copyright file=" Fund_B_Consume.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: Fund_B_Consume.cs
// * history : Created by T4 07/10/2019 15:15:39 
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
    public class Fund_B_ConsumeApp
    {
        private IFund_B_ConsumeRepository service = new Fund_B_ConsumeRepository();

        public List<Fund_B_ConsumeEntity> GetList(Pagination pagination, string queryJson)
        {
            var expression = ExtLinq.True<Fund_B_ConsumeEntity>();
            var queryParam = queryJson.ToJObject();
            if (!queryParam["keyword"].IsEmpty())
            {
                string keyword = queryParam["keyword"].ToString();
                expression = expression.And(t => t.Werks.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }
        public List<Fund_B_ConsumeEntity> GetList(Pagination pagination, System.Linq.Expressions.Expression<Func<Fund_B_ConsumeEntity, bool>> expression)
        {
            return service.FindList(expression, pagination);
        }
        public Fund_B_ConsumeEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void Delete(Fund_B_ConsumeEntity entity)
        {
            service.Delete(entity);
        }
        public string GetMaxCode()
        {
            var da = DateTime.Now.ToString("yyyyMMdd");
            string maxCode = new Data.RepositoryBase<Fund_B_ConsumeEntity>().Max(t => t.Code.StartsWith(da), p => p.Code);
            if (string.IsNullOrEmpty(maxCode))
            {
                maxCode = DateTime.Now.ToString("yyyyMMdd") + "0001";
            }
            else
            {
                int num = int.Parse(maxCode.Substring(8, 4)) + 1;
                maxCode = maxCode.Substring(0, 8) + num.ToString().PadLeft(4, '0');
            }
            return maxCode;
        }
        public void SubmitForm(Fund_B_ConsumeEntity entity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                entity.Modify(keyValue);
                service.Update(entity);
            }
            else
            {
                //if (string.IsNullOrEmpty(entity.Code))
                //{
                entity.Code = GetMaxCode();
                //}
                entity.Create();
                service.Insert(entity);
            }
        }
    }
}