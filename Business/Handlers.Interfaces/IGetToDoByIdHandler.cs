using ToDoListDDD.API.Queries.Requests;
using ToDoListDDD.Business.Queries.Responses;

namespace ToDoListDDD.Business.Handlers.Interfaces
{
    public interface IGetToDoByIdHandler
    {
        GetToDoByIdResponse Handle(GetToDoByIdRequest command);
    }
}
