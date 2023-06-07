using System.ComponentModel.DataAnnotations.Schema;
using Advertisement.Domain.Common;

namespace Advertisement.Domain.Entites;

public class File : BaseEntity
{
    public string Name { get; set; }
    public string Type { get; set; }
    public string Path { get; set; }
    public Advertisement Advertisement { get; set; }
}