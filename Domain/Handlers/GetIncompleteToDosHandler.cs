using MediatR;
using System.Threading;
using System.Threading.Tasks;
using ToDoListDDD.API.Queries.Requests;
using ToDoListDDD.Business.Queries.Responses;
using ToDoListDDD.Domain.Repositories;

namespace ToDoListDDD.Domain.Handlers
{
    public class GetIncompleteToDosHandler : IRequestHandler<GetIncompleteToDosRequest, GetIncompleteToDosResponse>
    {
        IToDoRepository _repository;
        public GetIncompleteToDosHandler(IToDoRepository repository)
        {
            _repository = repository;
        }
        public Task<GetIncompleteToDosResponse> Handle(GetIncompleteToDosRequest request, CancellationToken cancellationToken)
        {
            var todoItems = _repository.GetIncompleteItems();
            var result = new GetIncompleteToDosResponse
            {
                IncompleteItems = todoItems
            };
            return Task.FromResult(result);
        }
    }
}
