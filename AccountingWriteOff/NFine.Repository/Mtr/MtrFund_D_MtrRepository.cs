//-----------------------------------------------------------------------
// <copyright file=" MtrFund_D_Mtr.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: MtrFund_D_Mtr.cs
// * history : Created by T4 07/09/2019 16:02:47 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Data;
using NFine.Domain.Entity.Mtr;
using NFine.Domain.IRepository.Mtr;
using NFine.Repository.Hrm;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Text;

namespace NFine.Repository.Mtr
{
    public class MtrFund_D_MtrRepository : RepositoryBase<MtrFund_D_MtrEntity>, IMtrFund_D_MtrRepository
    {
        public int UpdatePrice(string keyValue, decimal price)
        {
            DbParameter[] parameter =
              {
                    new MySqlParameter("@Price",price),

                    new MySqlParameter("@keyValue",keyValue),
            };
            return this.Update("update MtrFund_D_Mtr set Price=@Price where F_Id=@keyValue", parameter);
        }
    }
}