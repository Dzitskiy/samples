using Microsoft.AspNetCore.Mvc;
using ToDoList.Core.Models;
using ToDoList.Core.Services;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoItemService _toDoItemService;

        private readonly ILogger<ToDoController> _logger;

        public ToDoController(ILogger<ToDoController> logger, IToDoItemService toDoItemService)
        {
            _logger = logger;
            _toDoItemService = toDoItemService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var items = _toDoItemService.GetAll();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = _toDoItemService.GetById(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Add([FromBody] ToDoItem item)
        {
            if (item == null)
            {
                return BadRequest("Item cannot be null");
            }
            _toDoItemService.Add(item);
            return CreatedAtAction(nameof(GetById), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] ToDoItem item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest("Item is invalid");
            }
            var existingItem = _toDoItemService.GetById(id);
            if (existingItem == null)
            {
                return NotFound();
            }
            _toDoItemService.Update(item);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingItem = _toDoItemService.GetById(id);
            if (existingItem == null)
            {
                return NotFound();
            }
            _toDoItemService.Delete(id);
            return NoContent();
        }
    }
}
