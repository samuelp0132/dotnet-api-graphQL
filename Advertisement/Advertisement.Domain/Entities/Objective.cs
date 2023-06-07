using Advertisement.Domain.Common;

namespace Advertisement.Domain.Entites;

public class Objective : BaseEntity
{
    public string Type { get; set; }
    public string Description { get; set; }
    
    public Campaign Campaign { get; set; }
    
    public int CampaignId { get; set; }
}