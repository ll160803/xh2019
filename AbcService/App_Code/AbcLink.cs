using BankService.Pub;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Web;
using System.Web.Services;

namespace BankService
{
    /// <summary>
    /// Summary description for AbcLink
    /// </summary>
    [WebService(Namespace = "http://www.whxh.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class AbcLink : System.Web.Services.WebService
    {
        private AbcService Abc;

        /// <summary>
        /// Socket连接测试
        /// </summary>
        /// <returns>连接状态</returns>
        [WebMethod]
        public string ConnectTest1()
        {
            Abc = new AbcService();
            Socket s = Abc.ConnectSocket(); //ConnectSocket("192.168.1.221", 3837);
            //Socket s = Abc.ConnectSocket("192.168.207.248", 15028); 
            if (s.Connected)
            {
                Common.WriteLog("-----------------Socket连接成功------------------");
                return "Socket连接成功";
            }
            else ;
            {
                Common.WriteLog("-----------------Socket连接失败-----------------");
                return "Socket连接失败";
            }
        }

        /// <summary>
        /// Socket连接测试
        /// </summary>
        /// <param name="server">ABC银企通服务器IP</param>
        /// <param name="port">ABC银企通服务器端口</param>
        /// <returns></returns>
        [WebMethod]
        public string ConnectTest2(string server, int port)
        {
            Abc = new AbcService();
            Socket s = Abc.ConnectSocket(server, port);
            if (s.Connected)
            {
                Common.WriteLog("-----------------Socket连接成功-----------------");
                return "Socket连接成功";
            }
            else ;
            {
                Common.WriteLog("-----------------Socket连接失败-----------------");
                return "Socket连接失败";
            }
        }


        /// <summary>
        /// Socket通讯
        /// </summary>
        /// <param name="server">ABC银企通通讯平台客户端IP</param>
        /// <param name="port">ABC银企通通讯平台客户端端口</param>
        /// <param name="xml_doc">XML报文</param>
        /// <returns>报文</returns>
        [WebMethod]
        public string SocketCom(string server, int port, string xml_doc)
        {
            if (Abc == null)
            {
                Abc = new AbcService();
            }
            return Abc.SocketSendReceive(server, port, xml_doc);
        }

        /// <summary>
        /// Socket通讯
        /// </summary>
        /// <param name="xml_doc">XML报文</param>
        /// <returns>报文</returns>
        [WebMethod]
        public string SocketSend(string xml_doc)
        {
            if (Abc == null)
            {
                Abc = new AbcService();
            }
            return Abc.SocketSendReceive(xml_doc);
        }

        /// <summary>
        /// 读取FTP文件
        /// </summary>
        /// <param name="filename">文件</param>
        /// <returns>文本字符串</returns>
        [WebMethod]
        public string ReadFTPFile(string filename)
        {
            filename = @"D:\中国农业银行银企通通讯平台(2.5测试版不带KEY)\data\" + filename;
            StreamReader srReadFile = new StreamReader(filename, Encoding.Default);

            string strReadText = "";
            // 读取流直至文件末尾结束
            while (!srReadFile.EndOfStream)
            {
                strReadText = srReadFile.ReadToEnd();// srReadFile.ReadLine(); //读取每行数据
                //Console.WriteLine(strReadLine); //屏幕打印每行数据
            }

            // 关闭读取流文件
            srReadFile.Close();

            Common.WriteLog("----------------返回FTP文件文本-----------------");
            Common.WriteLog(strReadText);
            Common.WriteLog("----------------返回FTP文件文本-----------------");
            return strReadText;
        }
    }
}
