using Advertisement.Domain.Common;

namespace Advertisement.Domain.Entites;

public class Audience : BaseEntity
{
    public string Visualizations { get; set; }
    public string Interests { get; set; }
    public virtual Campaign Campaign { get; set; }
    public int CampaignId { get; set; }
}