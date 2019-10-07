using MediatR;

namespace MediatR_Lib.SampleQuery
{
    public class QueryEvent : IRequest<string>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
