using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatApplication.ServiceReference1;

namespace ChatApplication
{
    class User
    {
        public string Nickname { get; set; }
        private ChatServiceClient _client;

        public User(string nickname)
        {
            Nickname = nickname;
            _client = new ChatServiceClient();
        }

        public void Join()
        {
            _client.ReceiveMessage($"{Nickname} has joined!");
        }

        public void Leave()
        {
            _client.ReceiveMessage($"{Nickname} has left.");
        }

        public void Write(string msg)
        {
            _client.ReceiveMessage(Nickname+": "+ msg);
        }
    }
}
