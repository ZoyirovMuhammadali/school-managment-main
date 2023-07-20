using System.ComponentModel.DataAnnotations;

namespace School.Domain.Entities.Students;

public class Student : Auditable
{
    [MaxLength(50)]
    public string Name { get; set; } = String.Empty;
    public DateOnly Dob { get; set; }
    public string Gender { get; set; } = String.Empty;
    [MaxLength(13)]
    public string PhoneNumber { get; set; } = String.Empty;
    public string Rollno { get; set; } = String.Empty;
    public string Adress { get; set; } = String.Empty;
    public long Klass_id { get; set; }
}
