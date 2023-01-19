using MediatR;
using ToDoListDDD.Business.Queries.Responses;

namespace ToDoListDDD.API.Queries.Requests
{
    public class GetIncompleteToDosRequest : IRequest<GetIncompleteToDosResponse> 
    {    }
}
