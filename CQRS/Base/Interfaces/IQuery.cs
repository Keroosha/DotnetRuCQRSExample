using MediatR;

namespace CQRS.Base.Interfaces
{
    public interface IQuery<T> : IRequest<T>
    {
        
    }
}