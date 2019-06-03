using System;
using System.Data;
using System.Data.OleDb;

namespace BankService.Pub
{
	public class ProcParam
	{
		public string ParamName;
		public OleDbType ParamType;
		public object ParamValue;

		public ProcParam(string Name, OleDbType Type, object Value)
		{
			ParamName = Name;
			ParamType = Type;
			ParamValue = Value;
		}
	}

	public class SQL
	{
		public static OleDbDataAdapter adp = new OleDbDataAdapter(); 
		public static string Provider = "";
		public static string DataSource = "";
		public static string UserID = "";
		public static string Password = "";
        public static string Catalog = "";

		public SQL()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}


		public static Return SQLQuery(string sSQL, ref DataTable tb, ref OleDbCommand cmd)
		{
			try
			{
				Common.WriteLog("SQQ:: SQL = " + sSQL);
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = sSQL;
				adp.SelectCommand = cmd;

				tb = new DataTable();

				adp.Fill(tb);

				for (int i = 0; i < Math.Min(tb.Rows.Count, 100); i ++)
				{
					for (int j = 0; j < tb.Columns.Count; j ++)
					{
						Common.WriteLog("SQQ:: " + tb.Columns[j].ColumnName + " = " + tb.Rows[i][j]);
					}
				}
				Common.WriteLog("SQQ:: [SUCCESS]");
				return new Return(true, null);
			}
			catch(Exception e)
			{
				Common.WriteLog("SQQ:: [FAILURE] " + e.Message);
                return new Return(false, e.Message);
			}
		}

		public static string SQLValue(string sSQL, ref OleDbCommand cmd)
		{
			try
			{
				Common.WriteLog("SQV:: SQL = " + sSQL);
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = sSQL;
				adp.SelectCommand = cmd;

				DataTable tb = new DataTable();

				adp.Fill(tb);

				for (int i = 0; i < tb.Rows.Count; i ++)
				{
					for (int j = 0; j < tb.Columns.Count; j ++)
					{
						Common.WriteLog("SQV:: " + tb.Columns[j].ColumnName + " = " + tb.Rows[i][j]);
					}
				}
				Common.WriteLog("SQV:: [SUCCESS]");
				if (tb.Rows.Count > 0)
				{
					return tb.Rows[0][0].ToString().Trim();
				}
				else
				{
					return "";
				}
			}
			catch(Exception e)
			{
				Common.WriteLog("SQV:: [FAILURE] " + e.Message);
				return "";
			}
		}

		public static bool SQLExist(string sSQL, ref OleDbCommand cmd)
		{
			try
			{
				Common.WriteLog("SQE:: SQL = " + sSQL);
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = sSQL;
				adp.SelectCommand = cmd;

				DataTable tb = new DataTable();

				adp.Fill(tb);

				for (int i = 0; i < tb.Rows.Count; i ++)
				{
					for (int j = 0; j < tb.Columns.Count; j ++)
					{
						Common.WriteLog("SQE:: " + tb.Columns[j].ColumnName + " = " + tb.Rows[i][j]);
					}
				}
				Common.WriteLog("SQE:: [SUCCESS]");
                if (Common.StrToIntDef(tb.Rows[0][0].ToString(), 0) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
			catch(Exception e)
			{
				Common.WriteLog("SQE:: [FAILURE] " + e.Message);
				return false;
			}
		}

		public static Return SQLExec(string sSQL, ref OleDbCommand cmd)
		{
			try
			{
				Common.WriteLog("SQC:: SQL =" + sSQL);
				cmd.Parameters.Clear();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = sSQL;

                int ret = cmd.ExecuteNonQuery();
                /*
                if ( ret != 1)
                {
                    return new Return(false, "影响行数[" + ret + "]错误");
                }
                */

				Common.WriteLog("SQC:: [SUCCESS]");
				return new Return(true, null);
			}
			catch(Exception e)
			{
				Common.WriteLog("SQC:: [FAILURE] " + e.Message);
				return new Return(false, e.Message);
			}
		}

		public static Return SQLProc(ref OleDbCommand cmd, string sProcName, params ProcParam[] pProcParams)
		{
			try
			{
				Common.WriteLog("SQP:: ProcName = " + sProcName);
				for (int i = 0; i < pProcParams.Length; i ++)
				{
					Common.WriteLog("SQE:: " + pProcParams[i].ParamName + " = " + pProcParams[i].ParamValue);
				}
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = sProcName;
				cmd.Parameters.Clear();

				OleDbParameter para;

				for (int i = 0; i < pProcParams.Length; i ++)
				{
					para = cmd.Parameters.Add(pProcParams[i].ParamName, pProcParams[i].ParamType);
					para.Direction = ParameterDirection.Input;
					para.Value = pProcParams[i].ParamValue;
				}

				para = cmd.Parameters.Add("V_RET", OleDbType.Numeric);
				para.Direction = ParameterDirection.Output;

				para = cmd.Parameters.Add("V_ERRMSG", OleDbType.VarChar, 80);
				para.Direction = ParameterDirection.Output;

				cmd.ExecuteNonQuery();
				
				string sRet = cmd.Parameters["V_RET"].Value.ToString().Trim();
				string sMessage = cmd.Parameters["V_ERRMSG"].Value.ToString().Trim();

				cmd.Parameters.Clear();
				Common.WriteLog("SQP:: " + "RET = " + sRet + " MESSAGE = " + sMessage);
				if (Common.StrToIntDef(sRet, -1) < 0)
				{
					return new Return(false, sMessage);
				}
				else
				{
					return new Return(true, null);
				}
			}
			catch(Exception e)
			{
				Common.WriteLog("SQP:: [FAILURE] " + e.Message);
				return new Return(false, e.Message);
			}
		}
	}
}
