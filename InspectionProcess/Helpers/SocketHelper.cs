using InspectionProcess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace InspectionProcess.Helpers
{
    public static class SocketHelper
    {
        public async static Task ManageSocketAsync(int inspectionResultId, int inspectionId)
        {
            Task.Factory.StartNew(() => ManageSocket(inspectionResultId, inspectionId));
        }
        public static void ManageSocket(int inspectionResultId, int inspectionId)
        {
            // (1) 소켓 객체 생성 (TCP 소켓)
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // (2) 서버에 연결
            var ep = new IPEndPoint(IPAddress.Parse("192.168.6.91"), 9999);
            sock.Connect(ep);

            string cmd = string.Empty;
            byte[] receiverBuff = new byte[8192];

            cmd = inspectionResultId.ToString() + "," + inspectionId.ToString();

            //TODO : inspectionId, inspectionResultId cmd에 담아줌
            byte[] buff = Encoding.UTF8.GetBytes(cmd);

            // (3) 서버에 데이타 전송
            sock.Send(buff, SocketFlags.None);

            // (4) 서버에서 데이타 수신
            int n = sock.Receive(receiverBuff);

            string data = Encoding.UTF8.GetString(receiverBuff, 0, n);
            Console.WriteLine(data);

            // (5) 소켓 닫기
            sock.Close();
        }
    }
}
