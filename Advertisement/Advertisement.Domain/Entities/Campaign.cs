using Advertisement.Domain.Common;

namespace Advertisement.Domain.Entites;

public class Campaign : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Enums.CampaignStatus Status { get; set; }
    public virtual Objective Objective { get; set; }
    public virtual List<Advertisement> Advertisement { get; set; }
    public virtual Audience Audience { get; set; }
    //public Interest Interest { get; set; }
}
