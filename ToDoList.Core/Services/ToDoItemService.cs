using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Core.Models;

namespace ToDoList.Core.Services
{
    /// <inheritdoc cref="ToDoItemService"/>
    public class ToDoItemService : IToDoItemService
    {
        private readonly List<ToDoItem> _items;
        private int _nextId = 1;

        public ToDoItemService()
        {
            _items = new List<ToDoItem>();

            Add(new ToDoItem
            {
                Id = 1,
                Title = "Buy groceries",
                Description = "Milk, Bread, Eggs",
                IsCompleted = false,
                DueDate = DateTime.Now.AddDays(2)
            });
            Add(new ToDoItem
            {
                Id = 2,
                Title = "Complete project report",
                Description = "Finalize the report and send it to the manager",
                IsCompleted = false,
                DueDate = DateTime.Now.AddDays(5)
            });
        }

        public IEnumerable<ToDoItem> GetAll() =>  _items.OrderBy(i => i.Id);

        public ToDoItem GetById(int id) => _items.FirstOrDefault(i => i.Id == id);

        public void Add(ToDoItem item) 
        {
            item.Id = _nextId++;
            _items.Add(item);
        }

        public void Update(ToDoItem item) 
        {
            var existingItem = GetById(item.Id);
            if (existingItem != null)
            {
                existingItem.Title = item.Title;
                existingItem.Description = item.Description;
                existingItem.IsCompleted = item.IsCompleted;
                existingItem.DueDate = item.DueDate;
            }
        }
        public void Delete(int id) => _items.RemoveAll(i => i.Id == id);
    }
}
