using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Text;

namespace BankService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    public interface IAbcService
    {
        Socket ConnectSocket();
        Socket ConnectSocket(string server, int port);
        string SocketSendReceive(string xml_doc);
        string SocketSendReceive(string server, int port, string xml_doc);

        // TODO: Add your service operations here
    }

}
