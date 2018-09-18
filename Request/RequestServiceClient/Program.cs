using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RequestServiceClient.ServiceReference1;

namespace RequestServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            RequestClient client = new RequestClient();
            client.SendRequest("I work!");
        }
    }
}
