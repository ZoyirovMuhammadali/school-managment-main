namespace School.Domain.Entities.Expences;

public class Expences : Auditable
{
    public long Chargeamount { get; set; }
    public long Klass_id { get; set; }
    public long Subject_id { get; set; }

}
