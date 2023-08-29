using LaMa.SIC.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace LaMa.SIC.Core.Controllers
{
    public abstract class SICController : Controller
    {
        protected IActionResult SICView(object model, string title)
        {
            ViewBag.Title = title;
            return View("SICView", new SICModel
            {
                Model = model,
                Title = title
            });
        }
    }
}