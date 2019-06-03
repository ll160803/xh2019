using System;
using System.Collections.Generic;
using System.Web;
using System.Text;
using SAP.Middleware.Connector;

namespace BankService.Pub
{
    public class NCOConfig: IDestinationConfiguration
    {
        public RfcConfigParameters GetParameters(String destinationName)
        {
            RfcConfigParameters parms = new RfcConfigParameters();
            switch (destinationName)
            {
                case "D01_300":
                    parms.Add(RfcConfigParameters.Name, "D01_300");
                    parms.Add(RfcConfigParameters.AppServerHost, "192.168.64.29");     //SAP主机IP
                    parms.Add(RfcConfigParameters.SystemNumber, "00");                 //SAP实例
                    parms.Add(RfcConfigParameters.User, "COM_FI");                  //用户名
                    parms.Add(RfcConfigParameters.Password, "");                //密码
                    parms.Add(RfcConfigParameters.Client, "300");                      //Client
                    parms.Add(RfcConfigParameters.Language, "ZH");                     //登陆语言
                    parms.Add(RfcConfigParameters.PoolSize, "5");
                    parms.Add(RfcConfigParameters.MaxPoolSize, "10");
                    parms.Add(RfcConfigParameters.IdleTimeout, "500");
                    return parms;
                case "P01_800":
                    parms.Add(RfcConfigParameters.Name, "P01_800");
                    parms.Add(RfcConfigParameters.AppServerHost, "192.168.64.26");    //SAP主机IP
                    parms.Add(RfcConfigParameters.SystemNumber, "01");                //SAP实例
                    parms.Add(RfcConfigParameters.User, "COM_FI");                 //用户名
                    parms.Add(RfcConfigParameters.Password, "");               //密码
                    parms.Add(RfcConfigParameters.Client, "800");                     //Client
                    parms.Add(RfcConfigParameters.Language, "ZH");                    //登陆语言
                    parms.Add(RfcConfigParameters.PoolSize, "5");
                    parms.Add(RfcConfigParameters.MaxPoolSize, "10");
                    parms.Add(RfcConfigParameters.IdleTimeout, "500");
                    return parms;

                default:
                    return null;
            }
        }

        public bool ChangeEventsSupported()
        {
            return false;
        }

        public event RfcDestinationManager.ConfigurationChangeHandler ConfigurationChanged;
    }
}