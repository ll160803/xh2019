using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;
using System.Reflection;

namespace Ipedf.Hrp.Web.common
{
    public partial class LogHelper
    {
        private static ILog log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);   
        public static void Error(Exception exception)
        {
            log.Error(exception.Message, exception);
        }
        public static void Debug(object message)
        {
            log.Debug(message);
        }
        public static void Warn(object message)
        {
            log.Warn(message);
        }
        public static void Info(object message)
        {
            Info(message, 1);
        }
        public static void Info(object message,int flag)
        {
            if (flag == 0)
            {
                log.Info(message);
            }
            else
            {
                log.Error(message);
            }
        }
       
    }

}