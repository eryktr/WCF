using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using Request;

namespace RequestHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseAddress = new Uri("http://localhost:8000/Request");
            var selfHost = new ServiceHost(typeof(Request.Request), baseAddress);
            try
            {
                selfHost.AddServiceEndpoint(typeof(IRequest), new WSHttpBinding(), "RequestService");
                var smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);
                selfHost.Open();
                Console.WriteLine("The serbice is now open");
                Console.WriteLine();
                Console.WriteLine("Press <ENTER> to stop");
                Console.WriteLine();
                Console.ReadLine();
                selfHost.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
