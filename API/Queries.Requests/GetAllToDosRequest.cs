using MediatR;
using ToDoListDDD.Business.Queries.Responses;

namespace ToDoListDDD.API.Queries.Requests
{
    public class GetAllToDosRequest : IRequest<GetAllToDoItemsResponse> 
    { 
        //public string Message { get; set; }
    
    }
}
