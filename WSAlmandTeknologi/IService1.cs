using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using static WSAlmandTeknologi.ServiceModels;

namespace WSAlmandTeknologi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]

    public interface IService1
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/GetUser", BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]

        List<User> PostUser(string UserName, string Tipe);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetUser/{UserName}/{Tipe}", BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
       
        List<User> GetUser(string UserName, string Tipe);

    }
}
