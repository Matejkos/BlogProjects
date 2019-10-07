using MediatR.Pipeline;
using MediatR_Lib.SampleQuery;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR_Lib.PipeLine
{
    public class SamplePreprocesorBehaviour : IRequestPreProcessor<QueryEvent>
    {
        public Task Process(QueryEvent request, CancellationToken cancellationToken)
        {
            return Task.Run(()=>request.Surname = request.Surname + "????");
            
        }
    }
}
