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
        var client = new Client
        {
            Name = "Cleyson Lima",
            Email = "cleyson@mail.com",
            Purchases = 110,
            Type = 5,
        };
        return View(client);
    }

    public IActionResult ClientList()
    {
        var clients = new List<Client>();
        clients.Add(new Client { Name = "Cleyson Lima", Email = "cleyson@mail.com", Purchases = 10, Type = 1 });
        clients.Add(new Client { Name = "Juan Pablo", Email = "jua@mail.com", Purchases = 10, Type = 1 });
        clients.Add(new Client { Name = "Sara Cristine", Email = "sara@mail.com", Purchases = 10, Type = 1 });
        return View(clients);
    }
}