namespace School.Domain.Entities;

public abstract class Auditable
{
    public DateTime Created_at { get; set; }
    public DateTime Updated_at { get; set; }

}
