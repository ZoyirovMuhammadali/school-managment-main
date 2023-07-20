namespace School.Domain.Exceptions.Klasses;

public class KlassNotFoundException : NotFoundException
{
    public KlassNotFoundException()
    {
        this.TitleMessage = "Klass not found";
    }
}
