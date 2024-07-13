using Microsoft.AspNetCore.Mvc;
using ToDoList.Domain.VievModels.Task;
namespace ToDoList.Controllers
{
    public class TaskController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTaskVievModel model)
        {
            return Ok();
        }
    }
}