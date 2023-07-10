// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;

namespace Internal.Generated.WolverineHandlers
{
    // START: GET_querystring_string
    public class GET_querystring_string : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _wolverineHttpOptions;

        public GET_querystring_string(Wolverine.Http.WolverineHttpOptions wolverineHttpOptions) : base(wolverineHttpOptions)
        {
            _wolverineHttpOptions = wolverineHttpOptions;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            string name = httpContext.Request.Query["name"].FirstOrDefault();
            // Just saying hello in the code! Also testing the usage of attributes to customize endpoints
            var result_of_UsingQueryString = WolverineWebApi.TestEndpoints.UsingQueryString(name);
            await WriteString(httpContext, result_of_UsingQueryString);
        }

    }

    // END: GET_querystring_string
    
    
}

