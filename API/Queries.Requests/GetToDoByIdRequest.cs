using MediatR;
using ToDoListDDD.Business.Queries.Responses;

namespace ToDoListDDD.API.Queries.Requests
{
    public class GetToDoByIdRequest : IRequest<GetToDoByIdResponse>
    {
        public long Id { get; set; }
    }
}
