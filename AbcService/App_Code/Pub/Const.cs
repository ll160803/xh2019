using System;
using System.Configuration;

namespace BankService.Pub
{
	/// <summary>
	/// Const 的摘要说明。
	/// </summary>
	public class Const
	{
		public const string BankABC = "中国农业银行";
        public const string Server_IP = "192.168.70.100";//ConfigurationManager.AppSettings["ABCserver"].ToString();
        public const int PORT = 3837;//Convert.ToInt16( ConfigurationManager.AppSettings["Port"].ToString() );//3837;

		public Const()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
	}
}
