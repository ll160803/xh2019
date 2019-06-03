using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Text;
using System.Reflection;

namespace BankService.Pub
{
	public class Return
	{
		public bool Ret = false;
		public string Message;

		public Return()
		{
		}

		public Return(bool ret, string msg)
		{
			Ret = ret;
			Message = msg;
		}
	}

	public class Common
	{
		public Common()
		{
		}

		public static int StrToIntDef(object s, int i)
		{
			try
			{
				return int.Parse(s.ToString().Trim());
			}
			catch
			{
				return i;
			}
		}

		public static double StrToFloatDef(object s, double f)
		{
			try
			{
				return double.Parse(s.ToString().Trim());
			}
			catch
			{
				return f;
			}
		}

		public static bool IsShortDate(string s)
		{
			if (s.Trim().Length == 0)
			{
				return true;
			}
			else if (s.Trim().Length != 6)
			{
				return false;
			}
			try
			{
				Convert.ToDateTime("20" + s.Substring(0, 2) + "-" + s.Substring(2, 2) + "-" + s.Substring(4, 2));
				return true;
			}
			catch
			{
				return false;
			}
		}

		public static DateTime ToShortDate(string s)
		{
			if (s.Trim().Length == 0)
			{
				return DateTime.MaxValue;
			}
			else if (s.Trim().Length != 6)
			{
				return DateTime.MaxValue;
			}
			try
			{
				return Convert.ToDateTime("20" + s.Substring(0, 2) + "-" + s.Substring(2, 2) + "-" + s.Substring(4, 2));
			}
			catch
			{
				return DateTime.MaxValue;
			}
		}

		public static string GetDate()
		{
            return DateTime.Now.ToString("yyyyMMdd");
		}

		public static string GetDate(DateTime date)
		{
            return date.ToString("yyyyMMdd");
        }

		public static string GetLongDate()
		{
            return DateTime.Now.ToString("yyyyÄêMMÔÂdd");
		}

		public static string GetTime()
		{
            return DateTime.Now.ToString("HHmmss");
		}

		public static string GetTime(DateTime time)
		{
            return time.ToString("HHmmss");
		}

		public static string GetLongTime()
		{
            return DateTime.Now.ToString("HH:mm:ss");
		}

		public static void WriteLog(object obj)
		{
			try
			{
				string sFileName = Assembly.GetExecutingAssembly().GetName().CodeBase;
				//sFileName = Path.GetTempPath() + GetDate() + @".log";
                sFileName = "D:\\BankService\\" + GetDate() + ".log"; 

				StreamWriter sw = null;
				if (File.Exists(sFileName))
				{
					sw = File.AppendText(sFileName);
				}
				else
				{
					sw = File.CreateText(sFileName);
				}
				sw.WriteLine("[" + GetLongTime() + "] " + obj);
				sw.Close();
			}
			catch
			{
				return;
			}
		}
	}
}
