using System.ComponentModel.DataAnnotations;
namespace bat.Models;
  public class Student
   {
    [Key]
    public string NameID { get; set; }
    public string FullName {get; set; }
    public string Email {get; set;}
    
   }

