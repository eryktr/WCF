using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using SimpleChat;

namespace ChatHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseuri = new Uri("http://localhost:8000");
            var host = new ServiceHost(typeof(ChatService), baseuri);
            try
            {
                host.AddServiceEndpoint(typeof(IChatService), new BasicHttpBinding(), "Chat");
                host.AddServiceEndpoint(typeof(IChatService), new BasicHttpBinding(), "RemoteChat");
                var smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                host.Description.Behaviors.Add(smb);
                host.Open();
                Console.WriteLine("Chat is ready!");
                Console.ReadLine();
                host.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                host.Abort();
            }
        }
    }
}
