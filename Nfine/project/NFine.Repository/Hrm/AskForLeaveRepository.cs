//-----------------------------------------------------------------------
// <copyright file=" AskForLeave.cs" company="NFine">
// * Copyright (C) NFine.Framework  All Rights Reserved
// * version : 1.0
// * author  : NFine.Framework
// * FileName: AskForLeave.cs
// * history : Created by T4 06/14/2019 11:13:27 
// </copyright>
//-----------------------------------------------------------------------
using NFine.Data;
using NFine.Domain.Entity.Hrm;
using NFine.Domain.IRepository.Hrm;
using NFine.Repository.Hrm;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Text;

namespace NFine.Repository.Hrm
{
    public class AskForLeaveRepository : RepositoryBase<AskForLeaveEntity>, IAskForLeaveRepository
    {
        public List<AskForLeaveEntity> GetItemList(System.DateTime startTime, System.DateTime endTime, string userId, string keyValue)
        {
            StringBuilder strSql = new StringBuilder();
            if (string.IsNullOrEmpty(keyValue))
            {
                strSql.Append(@"SELECT
	* 
FROM
	hrm_askforleave 
WHERE
	HrmUserId = @UserId AND IsNew=1
	AND (
	 ( StartDate  >= @StartTime  AND  StartDate  <=  @EndTime  ) 
	OR (  EndDate  >=  @StartTime  AND  EndDate  <=  @EndTime  ) 
	OR (  StartDate  <= @StartTime  AND  EndDate  >=  @EndTime ) 
	)");
                DbParameter[] parameter =
                {
                 new MySqlParameter("@UserId",userId),
                 new MySqlParameter("@StartTime",startTime.ToShortDateString()),
                 new MySqlParameter("@EndTime",endTime.ToShortDateString())
            };

                return this.FindList(strSql.ToString(), parameter);
            }
            else
            {
                strSql.Append(@"SELECT
	* 
FROM
	hrm_askforleave 
WHERE
	HrmUserId = @UserId AND F_ID!=@keyvalue AND IsNew=1
	AND (
	 ( StartDate  >= @StartTime  AND  StartDate  <=  @EndTime  ) 
	OR (  EndDate  >=  @StartTime  AND  EndDate  <=  @EndTime  ) 
	OR (  StartDate  <= @StartTime  AND  EndDate  >=  @EndTime ) 
	)");
                DbParameter[] parameter =
                {
                    new MySqlParameter("@keyvalue",keyValue),
                 new MySqlParameter("@UserId",userId),
                 new MySqlParameter("@StartTime",startTime.ToShortDateString()),
                 new MySqlParameter("@EndTime",endTime.ToShortDateString())
            };

                return this.FindList(strSql.ToString(), parameter);
            }
        }
        public int UpdateAskState(string keyValue, int state)
        {
            DbParameter[] parameter =
                {
                    new MySqlParameter("@keyValue",keyValue),
                 new MySqlParameter("@state",state)
            };
            return this.Update("update hrm_askforleave set state=@state where F_Id=@keyValue", parameter);
        }
    }
}