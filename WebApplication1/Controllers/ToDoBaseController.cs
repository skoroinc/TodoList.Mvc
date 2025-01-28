using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ToDoList.Mvc.Controllers
{
    public abstract class ToDoBaseController : Controller
    {
        protected int CurrentUserId => int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
    }
}
