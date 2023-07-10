// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;

namespace Internal.Generated.WolverineHandlers
{
    // START: GET_querystring_enum
    public class GET_querystring_enum : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _wolverineHttpOptions;

        public GET_querystring_enum(Wolverine.Http.WolverineHttpOptions wolverineHttpOptions) : base(wolverineHttpOptions)
        {
            _wolverineHttpOptions = wolverineHttpOptions;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            WolverineWebApi.Direction direction = default;
            WolverineWebApi.Direction.TryParse<WolverineWebApi.Direction>(httpContext.Request.Query["direction"], out direction);
            // Just saying hello in the code! Also testing the usage of attributes to customize endpoints
            var result_of_UsingEnumQuerystring = WolverineWebApi.TestEndpoints.UsingEnumQuerystring(direction);
            await WriteString(httpContext, result_of_UsingEnumQuerystring);
        }

    }

    // END: GET_querystring_enum
    
    
}

