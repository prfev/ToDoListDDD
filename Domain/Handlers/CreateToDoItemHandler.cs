using System;
using ToDoListDDD.API.Commands.Requests;
using ToDoListDDD.Business.Commands.Responses;
using ToDoListDDD.Business.Handlers.Interfaces;
using ToDoListDDD.Domain.Entities;
using ToDoListDDD.Domain.Repositories;
using ToDoListDDD.Domain.Services;

namespace ToDoListDDD.Domain.Handlers
{
    public class CreateToDoItemHandler : ICreateToDoItemHandler
    {
        IToDoRepository _repository;
        IToDoValidationService _validationService;
        public CreateToDoItemHandler(IToDoRepository repository, IToDoValidationService validationService)
        {
            _repository = repository;
            _validationService = validationService;
        }
        public CreateToDoItemResponse Handle(CreateToDoItemRequest command)
        {

            _validationService.NameIsValid(command.Name);

            var todoItem = new ToDoItem(command.Name, command.Description);
            _repository.Save(todoItem);
            return new CreateToDoItemResponse
            {
                Id = todoItem.Id,
                Name = todoItem.Name,
                IsComplete = todoItem.IsComplete,
                Description = todoItem.Description,
                CreatedAt = DateTime.Now
            };

        }
    }
}
