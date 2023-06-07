
using Advertisement.Domain.Common;

namespace Advertisement.Domain.Entites;

public class Advertisement : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Url { get; set; }
    public string Aspect { get; set; }
    public Campaign Campaign { get; set; }
    public int? CampaignId { get; set; }
    public File File { get; set; }
    
    public int FileId { get; set; }
}