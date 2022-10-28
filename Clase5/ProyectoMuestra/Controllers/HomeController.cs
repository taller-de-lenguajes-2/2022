using System.Diagnostics;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using ProyectoMuestra.Models;

namespace ProyectoMuestra.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult AltaCliente(int id, string name)
    {
        return View();
    }

    
    [HttpPost]
    public string Welcome(string name, int numTimes = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    }

    [HttpPost]
    public IActionResult AltaCliente(Cliente cliente)
    {
        return View();
    }

    [HttpPost]
    public IActionResult AltaCliente(Cliente cliente)
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
