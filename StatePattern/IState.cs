using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    interface IState
    {
        void Connect();
        void ConnectSuccess();
        void ConnectFailed();
        void Disconnect();
        void Reconnect();
        void SendMessage();
        void Error();
        void Reset();
    }
}
