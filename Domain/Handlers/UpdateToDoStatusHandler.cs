using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListDDD.Domain.Commands.Requests;
using ToDoListDDD.Domain.Commands.Responses;
using ToDoListDDD.Infrastructure;

namespace ToDoListDDD.Domain.Handlers
{
    public class UpdateToDoStatusHandler : IUpdateToDoStatusHandler
    {
        IToDoRepository _repository;
        public UpdateToDoStatusHandler(IToDoRepository repository)
        {
            _repository = repository;
        }
        public UpdateToDoStatusResponse Handle(UpdateToDoStatusRequest command)
        {

            var updatedTodo = _repository.UpdateStatus(command.Id);
            return new UpdateToDoStatusResponse
            {
                Id = updatedTodo.Id,
                Name = updatedTodo.Name,
                Description = updatedTodo.Description,
                IsComplete = updatedTodo.IsComplete,
                CreatedAt = updatedTodo.CreatedAt
            };
        }
    }
}
