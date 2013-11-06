using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Dispatcher;
using System.ServiceModel;
using System.Net;
using System.ServiceModel.Channels;
using System.Reflection;

using Trustev.Api.v1_1;

namespace Trustev.Api.v1_1.Inspectors
{
    public class XAuthInspector : IClientMessageInspector
    {
        public void AfterReceiveReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
        }

        public object BeforeSendRequest(ref System.ServiceModel.Channels.Message request, IClientChannel channel)
        {

            HttpRequestMessageProperty httpRequestMessage;
            object httpRequestMessageObject;
            if (request.Properties.TryGetValue(HttpRequestMessageProperty.Name, out httpRequestMessageObject))
            {
                httpRequestMessage = httpRequestMessageObject as HttpRequestMessageProperty;
                if (string.IsNullOrEmpty(httpRequestMessage.Headers["X-Authorization"]))
                {
                    httpRequestMessage.Headers["X-Authorization"] = AuthenticationToken.Instance.UserName + " " + AuthenticationToken.Instance.Token;
                }
            }
            else
            {
                httpRequestMessage = new HttpRequestMessageProperty();
                httpRequestMessage.Headers.Add("X-Authorization", AuthenticationToken.Instance.UserName + " " + AuthenticationToken.Instance.Token);
                request.Properties.Add(HttpRequestMessageProperty.Name, httpRequestMessage);
            }
            return null;
        }
    }
}
