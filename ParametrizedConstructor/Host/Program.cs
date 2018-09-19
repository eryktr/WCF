using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using ParametrizedConstructor;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier("Hello");
            var baseuri = new Uri("http://localhost:8000/Test");
            var host = new ServiceHost(notifier, baseuri);
            try
            {
                host.AddServiceEndpoint(typeof(INotifier), new BasicHttpBinding(), "Constructor");
                var smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                host.Description.Behaviors.Add(smb);
                host.Open();
                Console.WriteLine("host running");
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
