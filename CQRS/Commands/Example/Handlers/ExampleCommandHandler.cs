using System.Threading;
using System.Threading.Tasks;
using CQRS.Base.Interfaces;
using MediatR;

namespace CQRS.Commands.Example.Handlers
{
    public class ExampleCommandHandler : ICommandHandler<ExampleCommand>
    {
        public async Task<Unit> Handle(ExampleCommand request, CancellationToken cancellationToken)
        {
            // TODO Do something useful here
            return new Unit();
        }
    }
}