using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListDDD.Domain.Commands.Requests;
using ToDoListDDD.Domain.Commands.Responses;
using ToDoListDDD.Infrastructure;

namespace ToDoListDDD.Domain.Handlers
{
    public class GetToDoByIdHandler : IGetToDoByIdHandler
    {
        IToDoRepository _repository;
        public GetToDoByIdHandler(IToDoRepository repository)
        {
            _repository = repository;
        }
        public GetToDoByIdResponse Handle(GetToDoByIdRequest command)
        {
            var todoItem = _repository.GetItemById(command.Id);
            return new GetToDoByIdResponse
            {
                Id = todoItem.Id,
                Name = todoItem.Name,
                IsComplete = todoItem.IsComplete,
                Description = todoItem.Description
            };
        }
    }
}
