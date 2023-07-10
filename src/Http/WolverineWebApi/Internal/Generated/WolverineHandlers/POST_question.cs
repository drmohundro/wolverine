// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;

namespace Internal.Generated.WolverineHandlers
{
    // START: POST_question
    public class POST_question : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _wolverineHttpOptions;

        public POST_question(Wolverine.Http.WolverineHttpOptions wolverineHttpOptions) : base(wolverineHttpOptions)
        {
            _wolverineHttpOptions = wolverineHttpOptions;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var (question, jsonContinue) = await ReadJsonAsync<WolverineWebApi.Question>(httpContext);
            if (jsonContinue == Wolverine.HandlerContinuation.Stop) return;
            // Just saying hello in the code! Also testing the usage of attributes to customize endpoints
            var arithmeticResults = WolverineWebApi.TestEndpoints.PostJson(question);
            await WriteJsonAsync(httpContext, arithmeticResults);
        }

    }

    // END: POST_question
    
    
}

