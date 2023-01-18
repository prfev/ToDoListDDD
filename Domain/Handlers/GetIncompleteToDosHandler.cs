using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListDDD.Domain.Commands.Responses;
using ToDoListDDD.Infrastructure;

namespace ToDoListDDD.Domain.Handlers
{
    public class GetIncompleteToDosHandler : IGetIncompleteToDosHandler
    {
        IToDoRepository _repository;
        public GetIncompleteToDosHandler(IToDoRepository repository)
        {
            _repository = repository;
        }
        public GetIncompleteToDosResponse Handle()
        {
            var todoItems = _repository.GetIncompleteItems();
            return new GetIncompleteToDosResponse
            {
                IncompleteItems = todoItems
            };
        }
    }
}
