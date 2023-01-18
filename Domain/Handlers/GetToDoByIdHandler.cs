using MediatR;
using System.Threading;
using System.Threading.Tasks;
using ToDoListDDD.API.Queries.Requests;
using ToDoListDDD.Business.Queries.Responses;
using ToDoListDDD.Domain.Exceptions;
using ToDoListDDD.Domain.Repositories;

namespace ToDoListDDD.Domain.Handlers
{
    public class GetToDoByIdHandler : IRequestHandler<GetToDoByIdRequest,GetToDoByIdResponse>
    {
        IToDoRepository _repository;
        public GetToDoByIdHandler(IToDoRepository repository)
        {
            _repository = repository;
        }
        public Task<GetToDoByIdResponse> Handle(GetToDoByIdRequest request, CancellationToken cancellationToken)
        {  
            try
            {
                var todoItem = _repository.GetItemById(request.Id);
                var result = new GetToDoByIdResponse
                {
                    Id = todoItem.Id,
                    Name = todoItem.Name,
                    IsComplete = todoItem.IsComplete,
                    Description = todoItem.Description,
                    LastChanged = todoItem.LastChanged
                };
                return Task.FromResult(result);
            }
            catch
            {
                throw new ToDoIdIsNotValidException($"Id:{request.Id} does not exist in database!");
            }
        }
    }
}
