using MediatR;
using System.Threading;
using System.Threading.Tasks;
using ToDoListDDD.API.Commands.Requests;
using ToDoListDDD.Business.Commands.Responses;
using ToDoListDDD.Domain.Exceptions;
using ToDoListDDD.Domain.Repositories;

namespace ToDoListDDD.Business.Handlers
{
    public class UpdateToDoDescriptionHandler : IRequestHandler<UpdateToDoDescriptionRequest, UpdateToDoDescriptionResponse>
    {
        IToDoRepository _repository;
        public UpdateToDoDescriptionHandler(IToDoRepository repository)
        {
            _repository = repository;
        }
        public Task<UpdateToDoDescriptionResponse> Handle(UpdateToDoDescriptionRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var updatedTodo = _repository.UpdateDescription(request.Id, request.Description);
                var result = new UpdateToDoDescriptionResponse
                {
                    Id = updatedTodo.Id,
                    Name = updatedTodo.Name,
                    Description = updatedTodo.Description,
                    IsComplete = updatedTodo.IsComplete,
                    LastChanged = updatedTodo.LastChanged
                };
                return Task.FromResult(result);
            }
            catch
            {
                throw new ToDoIdIsNotValidException($"Id: {request.Id} doesn't exist in DataBase! Please try again.");
            }
        }
    }
}
