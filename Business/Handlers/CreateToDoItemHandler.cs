using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using ToDoListDDD.API.Commands.Requests;
using ToDoListDDD.Business.Commands.Responses;
using ToDoListDDD.Domain.Entities;
using ToDoListDDD.Domain.Repositories;
using ToDoListDDD.Domain.Services;

namespace ToDoListDDD.Business.Handlers
{
    public class CreateToDoItemHandler : IRequestHandler<CreateToDoItemRequest, CreateToDoItemResponse>
    {
        IToDoRepository _repository;
        IToDoValidationService _validationService;
        public CreateToDoItemHandler(IToDoRepository repository, IToDoValidationService validationService)
        {
            _repository = repository;
            _validationService = validationService;
        }
        public Task<CreateToDoItemResponse> Handle(CreateToDoItemRequest request, CancellationToken cancellationToken)
        {
            _validationService.NameIsValid(request.Name);
            var todoItem = new ToDoItem(request.Name, request.Description);
            _repository.Save(todoItem);
            var result = new CreateToDoItemResponse
            {
                Id = todoItem.Id,
                Name = todoItem.Name,
                IsComplete = todoItem.IsComplete,
                Description = todoItem.Description,
                LastChanged = DateTime.Now
            };
            return Task.FromResult(result);
        }
    }
}
