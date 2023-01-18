using MediatR;
using ToDoListDDD.Business.Commands.Responses;

namespace ToDoListDDD.API.Commands.Requests
{
    public class UpdateToDoStatusRequest : IRequest<UpdateToDoStatusResponse>
    {
        public long Id { get; set; }
    }
}
