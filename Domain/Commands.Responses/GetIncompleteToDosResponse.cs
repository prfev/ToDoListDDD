using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListDDD.Domain.Entities;

namespace ToDoListDDD.Domain.Commands.Responses
{
    public class GetIncompleteToDosResponse
    {
        public IEnumerable<ToDoItem> IncompleteItems { get; set; }
    }
}
