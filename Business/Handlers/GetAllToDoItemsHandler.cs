using MediatR;
using System.Threading;
using System.Threading.Tasks;
using ToDoListDDD.API.Queries.Requests;
using ToDoListDDD.Business.Queries.Responses;
using ToDoListDDD.Domain.Repositories;

namespace ToDoListDDD.Business.Handlers
{
    public class GetAllToDoItemsHandler : IRequestHandler<GetAllToDosRequest, GetAllToDoItemsResponse>
    {
        IToDoRepository _repository;
        public GetAllToDoItemsHandler(IToDoRepository repository)
        {
            _repository = repository;
        }
        public Task<GetAllToDoItemsResponse> Handle(GetAllToDosRequest request, CancellationToken cancellationToken)
        {
            
            var todoItems = _repository.GetAllItems();
            var result = new GetAllToDoItemsResponse
            {
                ToDoItems = todoItems
            };
            return Task.FromResult(result);
        }
    }
}
