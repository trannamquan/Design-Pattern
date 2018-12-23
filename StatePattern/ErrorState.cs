using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class ErrorState : IState
    {
        MyNetwork myNetwork;

        public ErrorState(MyNetwork myNetwork)
        {
            this.myNetwork = myNetwork;
        }

        public void Connect()
        {
            Console.WriteLine("In error state, cannot start a connection");
        }

        public void ConnectFailed()
        {
            Console.WriteLine("In error state, cannot start a connection");
        }

        public void ConnectSuccess()
        {
            Console.WriteLine("In error state, cannot start a connection");
        }

        public void Disconnect()
        {
            Console.WriteLine("In error state, cannot disconnect");
        }

        public void Error()
        {
            Console.WriteLine("In error state");
        }

        public void Reconnect()
        {
            Console.WriteLine("Start reconnect");
            myNetwork.SetState(myNetwork._connectingState);
        }

        public void Reset()
        {
            Console.WriteLine("Start reset");
            myNetwork.SetState(myNetwork._disconnectedState);
        }

        public void SendMessage()
        {
            Console.WriteLine("In error state");
        }
    }
}
