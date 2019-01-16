using MediatR;

namespace CQRS.Base.Interfaces
{
    public interface ICommand : IRequest 
    {
    }
    
    public interface ICommand<T> : IRequest<T>
    {
    }
}