using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using hospitalinformationsystem.Models;

namespace hospitalinformationsystem.Controllers;

public class ControlController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public ControlController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    Context contextdata = new Context();

    public IActionResult Index()
    {

        var patientInfoDegerler = contextdata.patientInfoModels.ToList();

        return View(patientInfoDegerler);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
