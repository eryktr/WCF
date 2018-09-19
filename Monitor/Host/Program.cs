using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using Monitor;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var atm = ObjectFactory.myATM;
            var baseuri = new Uri("http://localhost:800/Monitor");
            var host = new ServiceHost(typeof(ATMMonitor), baseuri);
            try
            {
                
                host.AddServiceEndpoint(typeof(IATMMonitor), new BasicHttpBinding(), "ATM");
                var smb = new ServiceMetadataBehavior
                {
                    HttpGetEnabled = true
                };
                host.Description.Behaviors.Add(smb);

                host.Open();
                Console.WriteLine("Host running!");
                atm.getMoney(200);
                Console.WriteLine();
                Console.ReadLine();
                host.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
                host.Abort();
            }


        }
    }
}
