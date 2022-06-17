using System.ComponentModel.DataAnnotations;

namespace hospitalinformationsystem.Models;

public class PatientInfoModel
{
   
   [Key]
   public int id { get; set; }
   public DateTime date { get; set; }
   public int patientNo { get; set; }
   public string? patientName { get; set; }
   public string? patientSurname { get; set; }
   public string? patientMotherName { get; set; }
   public string? patientFatherName { get; set; }
   public DateTime birthDate { get; set; }
   public float patientHeight { get; set; }
   public float patientWeight { get; set; }
   public string? bloodType { get; set; }
   public string? birthType { get; set; }
   public string? motherBloodType { get; set; }
   public string? fatherBloodType { get; set; }
   public string? InsertedBy { get; set; }
   
}
