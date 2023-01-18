using ToDoListDDD.Business.Handlers.Interfaces;
using ToDoListDDD.Business.Queries.Responses;
using ToDoListDDD.Domain.Repositories;

namespace ToDoListDDD.Domain.Handlers
{
    public class GetIncompleteToDosHandler : IGetIncompleteToDosHandler
    {
        IToDoRepository _repository;
        public GetIncompleteToDosHandler(IToDoRepository repository)
        {
            _repository = repository;
        }
        public GetIncompleteToDosResponse Handle()
        {
            var todoItems = _repository.GetIncompleteItems();
            return new GetIncompleteToDosResponse
            {
                IncompleteItems = todoItems
            };
        }
    }
}
