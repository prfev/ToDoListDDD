using ToDoListDDD.Business.Queries.Responses;

namespace ToDoListDDD.Business.Handlers.Interfaces
{
    public interface IGetIncompleteToDosHandler
    {
        GetIncompleteToDosResponse Handle();
    }
}
