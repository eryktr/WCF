using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ParametrizedConstructor
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Notifier : INotifier
    {
        private string _notification;

        public void Notify()
        {
            Console.WriteLine("Starting");
            Console.WriteLine(_notification);
            Console.WriteLine("Done");
        }

        public Notifier(string notification)
        {
            _notification = notification;
        }

        public Notifier()
        {

        }
    }
}
