using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Monitor
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ATMMonitor : IATMMonitor
    {
        private ATM _target;

        public ATMMonitor(ATM target)
        {
            _target = target;
        }

        public ATMMonitor() : this(ObjectFactory.myATM)
        {

        }

        public string GetReport()
        {
            return $"{_target.getLocation()} has {_target.getSum()} dollars inside";
        }
    }
}
