using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using hospitalinformationsystem.Models;

namespace hospitalinformationsystem.Controllers;

public class ControlController : Controller
{


    Context contextdata = new Context();

    public IActionResult Index()
    {

        var patientInfoDegerler = contextdata.patientInfoModels.ToList();

        return View(patientInfoDegerler);
    }

    [HttpGet]
    public IActionResult NewPatient()
    {


        return View();

    }

    [HttpPost]
    public IActionResult NewPatient(PatientInfoModel p)
    {

        Console.WriteLine("post");
        contextdata.patientInfoModels.Add(p);
        contextdata.SaveChanges();

        return RedirectToAction("Index");

    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
