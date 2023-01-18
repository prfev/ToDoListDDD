using System.Collections.Generic;
using ToDoListDDD.Domain.Entities;

namespace ToDoListDDD.Business.Queries.Responses
{
    public class GetIncompleteToDosResponse
    {
        public IEnumerable<ToDoItem> IncompleteItems { get; set; }
    }
}
