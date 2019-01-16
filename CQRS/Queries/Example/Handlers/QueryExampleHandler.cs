using System.Threading;
using System.Threading.Tasks;
using CQRS.Base.Interfaces;

namespace CQRS.Queries.Example.Handlers
{
    public class QueryExampleHandler : IQueryHandler<QueryExample, string>
    {
        public async Task<string> Handle(QueryExample request, CancellationToken cancellationToken)
        {
            // TODO Do something useful here
            return "Example query";
        }
    }
}