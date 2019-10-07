using MediatR.Pipeline;
using MediatR_Lib.SampleQuery;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR_Lib.PipeLine
{
    public class SamplePostProcessor : IRequestPostProcessor<QueryEvent, string>
    {
        public Task Process(QueryEvent request, string response, CancellationToken cancellationToken)
        {

            return Task.Run(() => response);
        }
    }
}
