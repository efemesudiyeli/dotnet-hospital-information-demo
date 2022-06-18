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

    public IActionResult DeletePatient(int id)
    {

        Console.WriteLine("delete");
        var deletepatient = contextdata.patientInfoModels.Find(id);
        contextdata.Remove(deletepatient);
        contextdata.SaveChanges();


        return RedirectToAction("Index");

    }

    [HttpGet]
    public IActionResult EditPatient(int id)
    {

        Console.WriteLine("edit");
        var editpatient = contextdata.patientInfoModels.Find(id);

        return View(editpatient);
    }

    [HttpPost]
     public IActionResult EditPatient(PatientInfoModel pm)
    {

        Console.WriteLine("edit");
        var updatepatient = contextdata.patientInfoModels.Find(pm.id);
        
        updatepatient.birthDate = pm.birthDate;
        updatepatient.birthType = pm.birthType;
        updatepatient.bloodType = pm.bloodType;
        updatepatient.date = pm.date;
        updatepatient.motherBloodType = pm.motherBloodType;
        updatepatient.fatherBloodType = pm.fatherBloodType;
        updatepatient.patientFatherName = pm.patientFatherName;
        updatepatient.patientMotherName = pm.patientMotherName;
        updatepatient.patientNo = pm.patientNo;
        updatepatient.patientHeight = pm.patientHeight;
        updatepatient.patientWeight = pm.patientWeight;
        updatepatient.patientSurname = pm.patientSurname;
        updatepatient.patientName = pm.patientName;
        updatepatient.InsertedBy = pm.InsertedBy;
      

        contextdata.SaveChanges();


        return RedirectToAction("Index");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
