using ToDoListDDD.API.Commands.Requests;
using ToDoListDDD.Business.Commands.Responses;

namespace ToDoListDDD.Business.Handlers.Interfaces
{
    public interface IRemoveToDoItemHandler
    {
        RemoveToDoItemResponse Handle(RemoveToDoItemRequest command);
    }
}
