using School.Domain.Enums;

namespace School.Domain.Entities.Exams;

public class Exam : Auditable
{
    public long Klass_id { get; set; }
    public long Subject_id { get; set; }
    public ExamStatus status { get; set; }
    public int Totalmarks { get; set; }
    public int Outofmarks { get; set; }
}
