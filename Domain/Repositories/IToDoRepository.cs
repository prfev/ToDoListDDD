using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListDDD.Domain.Entities;

namespace ToDoListDDD.Infrastructure
{
    public interface IToDoRepository
    {
        IEnumerable<ToDoItem> GetAllItems();
        ToDoItem GetItemById(long id);
        IEnumerable<ToDoItem> GetIncompleteItems();
        void Save(ToDoItem todoItem);
        void Remove(long id);
        ToDoItem UpdateStatus(long id);

    }
}
