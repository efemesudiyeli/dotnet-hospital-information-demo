using System.ComponentModel.DataAnnotations;

namespace hospitalinformationsystem.Models;

public class StaffModel
{

    [Key]
    public int id { get; set; }
    public DateTime date { get; set; }
    public int doctorNo { get; set; }
    public string? doctorName { get; set; }
    public string? doctorSurname { get; set; }


}
