using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR_Lib.SampleQuery
{
    public class SecondQueryHandler : IRequestHandler<QueryEvent, string>
    {
        public Task<string> Handle(QueryEvent request, CancellationToken cancellationToken)
        {
            return Task.Run(() => $"By {request.Name} {request.Surname} !!!");
        }
    }
}
