
using ToDoList.Core.Models;

namespace ToDoList.Core.Services
{
    /// <summary>
    /// Interface for a service that manages to-do items.
    /// </summary>
    public interface IToDoItemService
    {
        IEnumerable<ToDoItem> GetAll();
        ToDoItem GetById(int id);
        void Add(ToDoItem item);
        void Update(ToDoItem item);
        void Delete(int id);

    }
}
