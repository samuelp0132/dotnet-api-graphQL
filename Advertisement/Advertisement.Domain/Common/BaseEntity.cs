namespace Advertisement.Domain.Common;

public class BaseEntity 
{
    public int Id { get; set; }
    public DateTimeOffset CreatedOn { get; set; }
    public DateTimeOffset ModifiedOn { get; set; }
}