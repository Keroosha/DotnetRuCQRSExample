using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace CQRS.Base.Extensions
{
    public static class SignalRRequestExtension
    {
        public static Task<T> Execute<T>
            (this IRequest<T> request, IMediator mediator, CancellationToken cancellationToken)
        {
            return mediator.Send(request, cancellationToken);
        }
    }
}