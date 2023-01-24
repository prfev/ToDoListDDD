using System.Collections.Generic;
using ToDoListDDD.Domain.Entities;

namespace ToDoListDDD.Domain.Repositories
{
    public interface IToDoRepository
    {
        IEnumerable<ToDoItem> GetAllItems();
        ToDoItem GetItemById(long id);
        IEnumerable<ToDoItem> GetIncompleteItems();
        void Save(ToDoItem todoItem);
        void Remove(long id);
        ToDoItem UpdateStatus(long id);
        ToDoItem UpdateDescription(long id, string description);

    }
}
