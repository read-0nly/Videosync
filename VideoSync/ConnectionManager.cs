using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LumiSoft.Net.STUN.Client;
using LumiSoft.Net.STUN.Message;
using System.Net.Sockets;
using System.Net;

namespace VideoSync
{
    class ConnectionManager
    {
        public IPEndPoint Self;
        public int SelfPort;
        UdpClient udpClient = new UdpClient(new IPEndPoint(IPAddress.Any, 0));
        public ConnectionManager()
        {
            Self = getEndpoint();
        }
        IPEndPoint getEndpoint()
        {            
            // Query STUN server
            STUN_Result result = STUN_Client.Query("stun.l.google.com", 19302, udpClient.Client);
            if (result.NetType == STUN_NetType.UdpBlocked)
            {
                // UDP blocked or !!!! bad STUN server
                return null;
            }
            else
            {
                IPEndPoint publicEP = result.PublicEndPoint;
                // Do your stuff
                return publicEP;

            }
        }

        public string pingPong()
        {
            try
            {
                // Sends a message to the host to which you have connected.
                Byte[] sendBytes = Encoding.ASCII.GetBytes("Is anybody there?");


                // Sends a message to a different host using optional hostname and port parameters.
                UdpClient udpClientB = new UdpClient(11002);
                udpClientB.Send(sendBytes, sendBytes.Length, Self);

                //IPEndPoint object will allow us to read datagrams sent from any source.
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

                // Blocks until a message returns on this socket from a remote host.
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);

                // Uses the IPEndPoint object to determine which of these two hosts responded.
                string returnMessage = "This is the message you received " + returnData.ToString() + "<br>" +
                "This message was sent from " + RemoteIpEndPoint.Address.ToString() +
                                            " on their port number " + RemoteIpEndPoint.Port.ToString();

                udpClient.Close();
                udpClientB.Close();
                return returnMessage;
            }
            catch (Exception e)
            {
                return e.ToString();
            }

        }
    }
}
