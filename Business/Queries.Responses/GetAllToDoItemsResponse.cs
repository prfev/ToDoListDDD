using System.Collections.Generic;
using ToDoListDDD.Domain.Entities;

namespace ToDoListDDD.Business.Queries.Responses
{
    public class GetAllToDoItemsResponse
    {
        public IEnumerable<ToDoItem> ToDoItems { get; set; }
    }
}
