using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class ConnectedState : IState
    {
        private MyNetwork myNetwork;

        public ConnectedState(MyNetwork myNetwork)
        {
            this.myNetwork = myNetwork;
        }

        public void Connect()
        {
            Console.WriteLine("In connected state, cannot start a new connection");
        }

        public void ConnectFailed()
        {
            Console.WriteLine("In connected state, cannot start a new connection");
        }

        public void ConnectSuccess()
        {
            Console.WriteLine("In connected state, cannot start a new connection");
        }

        public void Disconnect()
        {
            Console.WriteLine("Start to disconnect...");
            myNetwork.SetState(myNetwork._disconnectedState);
        }

        public void Error()
        {
            Console.WriteLine("Errors occur !");
            myNetwork.SetState(myNetwork._errorState);
        }

        public void Reconnect()
        {
            Console.WriteLine("In connected state, cannot reconnects");
        }

        public void Reset()
        {
            Console.WriteLine("In connected state, cannot reset the connection");
        }

        public void SendMessage()
        {
            Console.WriteLine("In connected state...");
            myNetwork.SetState(myNetwork._connectedState);
        }
    }
}
