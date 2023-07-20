using School.Domain.Enums;

namespace School.Domain.Entities.TeacherAttends;

public class TeacherAttend : Auditable
{
    public long Teacher_id { get; set; }
    public DateTime Date { get; set; }
    public TeacherattendanceStatus Status { get; set; }

}
