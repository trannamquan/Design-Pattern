using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class ConnectingState : IState
    {
        private MyNetwork myNetwork;

        public ConnectingState(MyNetwork myNetwork)
        {
            this.myNetwork = myNetwork;
        }

        public void Connect()
        {
            Console.WriteLine("In connecting state, cannot start a new connection");
        }

        public void ConnectFailed()
        {
            Console.WriteLine("Connect failed !");
            myNetwork.SetState(myNetwork._disconnectedState);
        }

        public void ConnectSuccess()
        {
            Console.WriteLine("Connect successfully !");
            myNetwork.SetState(myNetwork._connectedState);
        }

        public void Disconnect()
        {
            Console.WriteLine("In connecting state, cannot disconnect");
        }

        public void Error()
        {
            Console.WriteLine("In connecting state, cannot found errors");
        }

        public void Reconnect()
        {
            Console.WriteLine("In connecting state, cannot reconnect");
        }

        public void Reset()
        {
            Console.WriteLine("In connecting state, cannot reset");
        }

        public void SendMessage()
        {
            Console.WriteLine("In connecting state...");
        }
    }
}
