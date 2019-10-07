using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR_Lib.PipeLine
{
    public class PiplineBahaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            Debug.WriteLine($"-- Handling Request {typeof(TRequest)}");
            var response = await next();
            Debug.WriteLine($"-- Finished Request {typeof(TRequest)}");
            return response;
        }
    }
}
