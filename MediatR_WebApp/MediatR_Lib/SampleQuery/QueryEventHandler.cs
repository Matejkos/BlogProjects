using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MediatR_Lib.SampleQuery
{
    public class QueryEventHandler : IRequestHandler<QueryEvent, string>
    {
        public Task<string> Handle(QueryEvent request, CancellationToken cancellationToken)
        {
            return Task.Run(() => $"Hello {request.Name} {request.Surname} !!!");
        }
    }
}
