using ToDoListDDD.Domain.Commands.Requests;
using ToDoListDDD.Domain.Commands.Responses;

namespace ToDoListDDD.Domain.Handlers
{
    public interface ICreateToDoItemHandler
    {
        CreateToDoItemResponse Handle(CreateToDoItemRequest command);
    }
}
