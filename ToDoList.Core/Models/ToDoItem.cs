using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Core.Models
{
    /// <summary>
    /// Represents a to-do item with properties such as Id, Name, Description, IsCompleted, StartDate, and EndDate.
    /// </summary>
    public class ToDoItem
    {
        /// <summary>
        /// Item identifier.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of the to-do item.
        /// </summary>
        public string Title{ get; set; }
        /// <summary>
        /// Description of the to-do item.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Indicates whether the to-do item is completed.
        /// </summary>
        public bool IsCompleted { get; set; }
        public DateTime DueDate { get; set; }
    }
}
