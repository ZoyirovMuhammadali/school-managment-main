namespace School.Domain.Exceptions.Feeses;

public class FeesNotFoundException : NotFoundException
{
    public FeesNotFoundException()
    {
        this.TitleMessage = "Fees not found";
    }
}
