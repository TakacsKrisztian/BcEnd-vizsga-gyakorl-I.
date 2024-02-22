namespace Takács_Krisztián_backend.Models;

public partial class Jegyek
{
    public int Id { get; set; }

    public int? JegySzammal { get; set; }

    public string? JegySzoveggel { get; set; }

    public DateOnly? BeirasDatuma { get; set; }

    public DateOnly? ModositasDatuma { get; set; }

    public int? IdTanarok { get; set; }

    public int? IdTantargyak { get; set; }

    public virtual Tanarok? IdTanarokNavigation { get; set; }

    public virtual Tantargyak? IdTantargyakNavigation { get; set; }
}