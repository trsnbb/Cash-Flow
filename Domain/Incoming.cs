using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

public class Incoming : BaseModel
{
    public Guid CategoryId { get; set; }

    [NotMapped]
    public string CategoryCaption { get; set; }

    public decimal Amount { get; set; }
}
