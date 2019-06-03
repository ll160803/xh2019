using BankService.Pub;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Web;

namespace BankService
{
    public class AbcService : IAbcService
    {
        /// <summary>
        /// Socket连接
        /// </summary>
        /// <param name="port">端口号</param>
        /// <returns>Socket对象</returns>
        public Socket ConnectSocket()
        {
            Socket skt = null;
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(Const.Server_IP), Const.PORT);
            Socket s = new Socket(ipe.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            Common.WriteLog("-----------------Socket开始连接-----------------");
            s.Connect(ipe);
            if (s.Connected)
            {
                Common.WriteLog("-----------------Socket连接成功------------------");
                skt = s;
                Common.WriteLog("-----------------返回Socket对象------------------");
            }

            return skt;

        }

        /// <summary>
        /// Socket连接
        /// </summary>
        /// <param name="server">银企直连客户端服务器</param>
        /// <param name="port">客户端端口</param>
        /// <returns>Socket对象</returns>
        public Socket ConnectSocket(string server, int port)
        {
            Socket skt = null;
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(server), port);
            Socket s = new Socket(ipe.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            Common.WriteLog("-----------------Socket开始连接-----------------");
            s.Connect(ipe);
            if (s.Connected)
            {
                Common.WriteLog("-----------------Socket连接成功------------------");
                skt = s;
                Common.WriteLog("-----------------返回Socket对象------------------");
            }
            return skt;
        }

        /// <summary>
        /// 通讯发送报文
        /// </summary>
        /// <param name="server">ABC银企通服务器IP 这里是连接农行客户端</param>
        /// <param name="port">端口  连接农行客户端，客户端登录后系统设置里会设置端口</param>
        /// <param name="xml_doc">XML报文</param>
        /// <returns>报文</returns>
        public string SocketSendReceive(string server, int port, string xml_doc)
        {
            Common.WriteLog("------------------------------------------------");
            Common.WriteLog("-------------------发送报文----------------------");
            Common.WriteLog(xml_doc.ToString());
            Common.WriteLog("------------------------------------------------");
            Byte[] byl = Encoding.Default.GetBytes(xml_doc);
            string _len = "0" + byl.Length.ToString().PadRight(6, ' ');//根据文档说明 报文前面要有7位数字，第一位是加密否标示，后面6位是报文的长度
            Byte[] bytesSent = Encoding.Default.GetBytes(_len + xml_doc);
            //Byte[] bytesSent = Encoding.GetEncoding("GBK").GetBytes(_len + xml_doc);
            Byte[] bytesReceived = new Byte[256];
            // Create a socket connection with the specified server and port.
            Socket s = ConnectSocket(server, port);

            if (s == null)
            {

                Common.WriteLog("---------------返回Socket对象为空----------------");
                throw new Exception("Error：通讯连接失败！请检查农行客户端是否登录！");
            }
            // Send request to the server.
            s.Send(bytesSent, bytesSent.Length, 0);
            // Receive the server home page content.
            int bytes = 0;
            string page = "";
            // The following will block until te page is transmitted.
            do
            {
                bytes = s.Receive(bytesReceived, bytesReceived.Length, 0);
                page = page + Encoding.Default.GetString(bytesReceived, 0, bytes);
            }
            while (bytes > 0);

            page = page.Remove(0, 7);
            Common.WriteLog("-------------------返回报文----------------------");
            Common.WriteLog(page.ToString());
            Common.WriteLog("------------------------------------------------");

            return page;
            ////GBK转换成UTF8

            ////声明字符集   
            //System.Text.Encoding utf8, gbk;
            ////gbk
            //gbk = System.Text.Encoding.GetEncoding("GBK");
            ////utf8   
            //utf8 = System.Text.Encoding.GetEncoding("utf-8");
            //byte[] gb;
            //gb = gbk.GetBytes(page);
            //gb = System.Text.Encoding.Convert(gbk, utf8, gb);
            ////返回转换后的字符   
            //return utf8.GetString(gb);
        }

        /// <summary>
        /// 通讯发送报文
        /// </summary>
        /// <param name="xml_doc">XML报文</param>
        /// <returns>报文</returns>
        public string SocketSendReceive(string xml_doc)
        {
            Common.WriteLog("------------------------------------------------");
            Common.WriteLog("-------------------发送报文----------------------");
            Common.WriteLog(xml_doc.ToString());
            Common.WriteLog("------------------------------------------------");
            Byte[] byl = Encoding.Default.GetBytes(xml_doc);
            string _len = "0" + byl.Length.ToString().PadRight(6, ' ');//根据文档说明 报文前面要有7位数字，第一位是加密否标示，后面6位是报文的长度
            Byte[] bytesSent = Encoding.Default.GetBytes(_len + xml_doc);
            Byte[] bytesReceived = new Byte[256];
            // Create a socket connection with the specified server and port.
            Socket s = ConnectSocket(Const.Server_IP, Const.PORT);
            if (s == null)
            {

                Common.WriteLog("---------------返回Socket对象为空----------------");
                throw new Exception("Error：通讯连接失败！请检查农行客户端是否登录！");
            }
            // Send request to the server.
            s.Send(bytesSent, bytesSent.Length, 0);
            // Receive the server home page content.
            int bytes = 0;
            string page = "";
            // The following will block until te page is transmitted.
            do
            {
                bytes = s.Receive(bytesReceived, bytesReceived.Length, 0);
                page = page + Encoding.Default.GetString(bytesReceived, 0, bytes);
            }
            while (bytes > 0);
            page = page.Remove(0, 7);
            Common.WriteLog("-------------------返回报文----------------------");
            Common.WriteLog(page.ToString());
            Common.WriteLog("------------------------------------------------");
            return page;
            ////GBK转换成UTF8

            ////声明字符集   
            //System.Text.Encoding utf8, gbk;
            ////gbk
            //gbk = System.Text.Encoding.GetEncoding("GBK");
            ////utf8   
            //utf8 = System.Text.Encoding.GetEncoding("utf-8");
            //byte[] gb;
            //gb = gbk.GetBytes(page);
            //gb = System.Text.Encoding.Convert(gbk, utf8, gb);
            ////返回转换后的字符   
            //return utf8.GetString(gb);

        }
    }
}