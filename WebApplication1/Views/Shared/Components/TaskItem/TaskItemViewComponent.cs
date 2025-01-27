using Microsoft.AspNetCore.Mvc;
using ToDoList.Domain.Entities;

namespace ToDoList.Mvc.Views.Shared.Components.TaskItem
{
    public class TaskItemViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(TaskApp task)
        {
            return View(task);
        }
    }
}
