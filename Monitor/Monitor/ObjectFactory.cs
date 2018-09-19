using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor
{
    public class ObjectFactory
    {
        public static ATM myATM = new ATM(1000, "London");
    }
}
