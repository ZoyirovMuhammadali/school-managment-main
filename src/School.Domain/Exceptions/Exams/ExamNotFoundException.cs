namespace School.Domain.Exceptions.Exams;

public class ExamNotFoundException : NotFoundException
{
    public ExamNotFoundException()
    {
        this.TitleMessage = "Exam not found";
    }
}
