using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Banco.Models;
using ViewModels;

namespace Banco.Controllers;

public class TurnosController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public TurnosController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult CrearTurno()
    {
        
        return View(new CrearTurnoViewModel());
    }

    
    [HttpPost]
    public IActionResult CrearTurno(CrearTurnoViewModel crearTurnoViewModel)
    {
     
        if(ModelState.IsValid)
        {
            //transformar esto a Modelo
        }

        // usar el caso de uso de crear turno - base datos  
        // turno creado correctamente 
        //
        return View();
    }

    public IActionResult ListarTurnosPendientes()
    {
        // nivel de acceso
        // Caso uso turnos pendientes(dia)
        // List<turnos> ListTurnos; 
        // transformar esto en algo que la vista pueda interpretar (turnoDiaViewModel) (adapter - mapper)
        
        return View(new List<TurnoDiaViewModel>());
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
