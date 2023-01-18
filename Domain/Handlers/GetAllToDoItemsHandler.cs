using ToDoListDDD.Domain.Commands.Responses;
using ToDoListDDD.Infrastructure;

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
