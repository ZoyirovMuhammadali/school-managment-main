namespace School.Domain.Entities.Subjects;

public class Subject : Auditable
{
    public string Subject_name { get; set; } = String.Empty;
    public long Klass_id { get; set; }

}
