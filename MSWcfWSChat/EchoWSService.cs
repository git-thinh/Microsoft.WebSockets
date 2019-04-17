using Microsoft.ServiceModel.WebSockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSWcfWSChat
{
    public class EchoWSService : WebSocketService
    {
        public override void OnOpen()
        {
            this.Send("Welcome!");
        }

        public override void OnMessage(string message)
        {
            string msgBack = string.Format("You have sent {0} at {1}", message, DateTime.Now.ToLongTimeString());
            this.Send(msgBack);
        }

        public override void OnMessage(Byte[] buffer)
        {

            string msgBack = string.Format("You have sent {0} at {1}", buffer.Length, DateTime.Now.ToLongTimeString());
            this.Send(msgBack);
        }

        protected override void OnClose()
        {
            base.OnClose();
        }

        protected override void OnError()
        {
            base.OnError();
        }
    }
}