﻿using System;
using SignalR.Client._20.Transports;

namespace SignalR.Client._20.Infrastructure
{
    public static class IHttpClientExtensions
    {
        public static EventSignal<IResponse> PostAsync(IHttpClient client, string url, Action<IRequest> prepareRequest)
        {
            return client.PostAsync(url, prepareRequest, postData: null);
        }
    }
}
