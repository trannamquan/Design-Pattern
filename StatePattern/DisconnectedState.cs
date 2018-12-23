using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class DisconnectedState : IState
    {
        MyNetwork myNetwork;

        public DisconnectedState(MyNetwork myNetwork)
        {
            this.myNetwork = myNetwork; 
        }

        public void Connect()
        {
            Console.WriteLine("Start to connect...");
            myNetwork.SetState(myNetwork._connectingState);
        }

        public void ConnectFailed()
        {
            Console.WriteLine("Please start a new connect. No connection detected");
        }

        public void ConnectSuccess()
        {
            Console.WriteLine("Please start a new connect. No connection detected");
        }

        public void Disconnect()
        {
            Console.WriteLine("No connection detected. Cannot start disconnect");
        }

        public void Error()
        {
            Console.WriteLine("No connection detected. No errors detected");
        }

        public void Reconnect()
        {
            Console.WriteLine("No connection detected. Cannot reconnect");
        }

        public void Reset()
        {
            Console.WriteLine("No connection detected. Cannot reset");
        }

        public void SendMessage()
        {
            Console.WriteLine("In disconnected state...");
        }
    }
}
