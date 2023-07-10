// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;
using WolverineWebApi;

namespace Internal.Generated.WolverineHandlers
{
    // START: GET_middleware_intrinsic
    public class GET_middleware_intrinsic : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _wolverineHttpOptions;
        private readonly WolverineWebApi.Recorder _recorder;

        public GET_middleware_intrinsic(Wolverine.Http.WolverineHttpOptions wolverineHttpOptions, WolverineWebApi.Recorder recorder) : base(wolverineHttpOptions)
        {
            _wolverineHttpOptions = wolverineHttpOptions;
            _recorder = recorder;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var beforeAndAfterEndpoint = new WolverineWebApi.BeforeAndAfterEndpoint();
            WolverineWebApi.BeforeAndAfterEndpoint.Before(_recorder);
            var result_of_GetRequest = beforeAndAfterEndpoint.GetRequest(_recorder);
            WolverineWebApi.BeforeAndAfterEndpoint.After(_recorder);
            await WriteString(httpContext, result_of_GetRequest);
        }

    }

    // END: GET_middleware_intrinsic
    
    
}

