using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var myNetwork = new MyNetwork();

            Console.WriteLine("My network status: "+ myNetwork._state.ToString());

            myNetwork.Connect();
            myNetwork.ConnectSuccess();
            Console.WriteLine("My network status: " + myNetwork._state.ToString());

            myNetwork.Disconnect();
            myNetwork.Reset();
            Console.WriteLine("My network status: " + myNetwork._state.ToString());

            myNetwork.Connect();
            myNetwork.ConnectFailed();
            Console.WriteLine("My network status: " + myNetwork._state.ToString());

            myNetwork.Connect();
            myNetwork.ConnectSuccess();
            myNetwork.SendMessage();
            Console.WriteLine("My network status: " + myNetwork._state.ToString());

            myNetwork.Error();
            Console.WriteLine("My network status: " + myNetwork._state.ToString());

            myNetwork.Reset();
            Console.WriteLine("My network status: " + myNetwork._state.ToString());

            Console.Read();
        }
    }
}
