using Microsoft.AspNetCore.Mvc;
using TWTodoList.Models;

namespace TWTodoList.Controllers;

public class TestController : Controller
{
    public IActionResult Index()
    {
        var todo = new Todo("Finalizar o curso de Razor da TreinaWeb", DateTime.Now);
        ViewBag.Name = "Cleyson";
        ViewBag.Todo = todo;
        TempData["name"] = "Cleyson";
        return View();
    }

    public IActionResult AnotherTest()
    {
        return View();
    }

    public IActionResult ClientDetails()
    {
        var client = new Client { Name = "Cleyson Lima", Email = "cleyson@mail.com" };
        return View(client);
    }
}