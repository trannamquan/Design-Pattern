using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class MyNetwork
    {
        public IState _connectedState { get; set; }
        public IState _connectingState { get; set; }
        public IState _disconnectedState { get; set; }
        public IState _errorState { get; set; }

        public IState _state { get; set; }

        public MyNetwork()
        {
            _connectedState = new ConnectedState(this);
            _connectingState = new ConnectingState(this);
            _disconnectedState = new DisconnectedState(this);
            _errorState = new ErrorState(this);

            _state = _disconnectedState;
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void Connect()
        {
            _state.Connect();
        }

        public void ConnectSuccess()
        {
            _state.ConnectSuccess();
        }

        public void ConnectFailed()
        {
            _state.ConnectFailed();
        }

        public void Disconnect()
        {
            _state.Disconnect();
        }

        public void Reconnect()
        {
            _state.Reconnect();
        }

        public void Reset()
        {
            _state.Reset();
        }

        public void SendMessage()
        {
            _state.SendMessage();
        }

        public void Error()
        {
            _state.Error();
        }

    }
}
