using System;
using System.Collections.Generic;
using System.Linq;
using ToDoListDDD.Domain.Entities;
using ToDoListDDD.Domain.Repositories;

namespace ToDoListDDD.Infrastructure
{
    public class ToDoRepository : IToDoRepository
    {
        private static ToDoDbContext _context;
        public ToDoRepository(ToDoDbContext context)
        {
            _context = context;
        }
        public IEnumerable<ToDoItem> GetAllItems()
        {
            return _context.ToDoItems.Select(x => x).ToList();
        }
        public ToDoItem GetItemById(long id)
        {
                return _context.ToDoItems.Find(id);
        }
        public IEnumerable<ToDoItem> GetIncompleteItems()
        {
            return _context.ToDoItems
                .Where(x => x.IsComplete == false)
                .Select(x => x)
                .ToList();
        }
        public void Save(ToDoItem todoItem)
        {
            _context.ToDoItems.Add(todoItem);
            _context.SaveChangesAsync();
        }
        public void Remove(long id)
        {
            var todoItem = _context.ToDoItems.Find(id);
            _context.ToDoItems.Remove(todoItem);
            _context.SaveChanges();
        }
        public ToDoItem UpdateStatus(long id)
        {
            var todoItem = _context.ToDoItems.Find(id);
            todoItem.IsComplete ^= true;
            todoItem.LastChanged = DateTime.Now;
            _context.SaveChanges();
            return todoItem;
            
        }

    }
}
