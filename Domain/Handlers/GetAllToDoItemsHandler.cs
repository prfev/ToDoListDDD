using ToDoListDDD.Business.Handlers.Interfaces;
using ToDoListDDD.Business.Queries.Responses;
using ToDoListDDD.Domain.Repositories;

namespace ToDoListDDD.Domain.Handlers
{
    public class GetAllToDoItemsHandler : IGetAllToDoItemsHandler
    {
        IToDoRepository _repository;
        public GetAllToDoItemsHandler(IToDoRepository repository)
        {
            _repository = repository;
        }
        public GetAllToDoItemsResponse Handle()
        {
            var todoItems = _repository.GetAllItems();
            return new GetAllToDoItemsResponse
            {
                ToDoItems = todoItems
            };       
        }
    }
}
