using System.ComponentModel.DataAnnotations;
namespace bat.Models;
public class Faculty
{
    [Key]
    public string FacultyID { get; set; }
    public string FacultyName { get; set; }
    public string FacultyEmail { get; set; }
}