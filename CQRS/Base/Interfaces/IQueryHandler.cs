using MediatR;

namespace CQRS.Base.Interfaces
{
    public interface IQueryHandler<TQuery, TReponse> : 
        IRequestHandler<TQuery, TReponse> where TQuery : IRequest<TReponse>
    {
        
    }
}