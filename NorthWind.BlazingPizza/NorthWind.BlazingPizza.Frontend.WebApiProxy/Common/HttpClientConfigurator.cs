﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Frontend.WebApiProxy.Common
{
    public class HttpClientConfigurator(
        Action<HttpClient> configureHttpClient,
        Action<IHttpClientBuilder> configureNamedHttpClient = null)
    {
        public Action<HttpClient> ConfigureHttpClient => configureHttpClient;
        public Action<IHttpClientBuilder> ConfigureNamedHttpClient => 
            configureNamedHttpClient;
    }
}
