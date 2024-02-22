namespace Takács_Krisztián_backend.Models;

public partial class Tantargyak
{
    public int Id { get; set; }

    public string? TantargyNev { get; set; }

    public string? TantargyLeiras { get; set; }

    public virtual ICollection<Jegyek> Jegyek { get; set; } = new List<Jegyek>();
}