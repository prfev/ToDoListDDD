using ToDoListDDD.API.Commands.Requests;
using ToDoListDDD.Business.Commands.Responses;

namespace ToDoListDDD.Business.Handlers.Interfaces
{
    public interface ICreateToDoItemHandler
    {
        CreateToDoItemResponse Handle(CreateToDoItemRequest command);
    }
}
