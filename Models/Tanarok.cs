namespace Takács_Krisztián_backend.Models;

public partial class Tanarok
{
    public int Id { get; set; }

    public string? VezetekNev { get; set; }

    public string? KeresztNev { get; set; }

    public string? Email { get; set; }

    public string? Nem { get; set; }

    public virtual ICollection<Jegyek> Jegyek { get; set; } = new List<Jegyek>();
}