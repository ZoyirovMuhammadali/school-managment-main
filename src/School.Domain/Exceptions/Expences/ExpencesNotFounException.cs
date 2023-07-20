namespace School.Domain.Exceptions.Expences;

public class ExpencesNotFounException : NotFoundException
{
    public ExpencesNotFounException()
    {
        this.TitleMessage = "Expence not found";
    }
}
