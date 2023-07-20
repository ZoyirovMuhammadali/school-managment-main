using System.ComponentModel.DataAnnotations;

namespace School.Domain.Entities.Teachers;

public class Teacher : Auditable
{
    [MaxLength(50)]
    public string Name { get; set; } = String.Empty;
    public DateOnly Dob { get; set; }
    public string Gender { get; set; } = String.Empty;
    [MaxLength(13)]
    public string PhoneNumber { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;
    public string Password { get; set; } = String.Empty
}
