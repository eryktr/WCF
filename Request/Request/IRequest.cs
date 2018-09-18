using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Request
{
    [ServiceContract]
    public interface IRequest
    {
        [OperationContract]
        void SendRequest(string request);
    }

    
}
