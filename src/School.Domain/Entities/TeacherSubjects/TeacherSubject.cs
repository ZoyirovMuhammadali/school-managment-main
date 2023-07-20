namespace School.Domain.Entities.TeacherSubjects;
public class TeacherSubjec : Auditable
{
    public long Klass_id { get; set; }
    public long Subject_id { get; set; }
    public long Teacher_id { get; set; }

}
