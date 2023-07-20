using School.Domain.Enums;

namespace School.Domain.Entities.StudentAttends;

public class StudentAttend : Auditable
{
    public long Klass_id { get; set; }
    public long Subject_id { get; set; }
    public StudenttendanceStatus Status { get; set; }
    public DateTime Date { get; set; }
    public string Rollno { get; set; } = String.Empty;

}
