namespace Takács_Krisztián_backend.Models.Dtos
{
    public record JegyDto (int Id, int? JegySzammal, string? JegySzoveggel, DateOnly? BeirasDatuma, DateOnly? ModositasDatuma, int? IdTanarok, int? IdTantargyak, Tanarok? IdTanarokNavigation, Tantargyak? IdTantargyakNavigation);
    public record CreateJegyDto (int? JegySzammal, string? JegySzoveggel, int? IdTanarok, int? IdTantargyak);
    public record ModifyJegyDto (int? JegySzammal, string? JegySzoveggel, int? IdTanarok, int? IdTantargyak);
    public record RemoveJegyDto (int Id);
}