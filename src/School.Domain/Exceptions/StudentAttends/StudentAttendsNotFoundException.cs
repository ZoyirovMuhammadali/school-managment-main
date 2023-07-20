namespace School.Domain.Exceptions.StudentAttends;

public class StudentAttendsNotFoundException : NotFoundException
{
    public StudentAttendsNotFoundException()
    {
        this.TitleMessage = "Studentattands not found";
    }
}
