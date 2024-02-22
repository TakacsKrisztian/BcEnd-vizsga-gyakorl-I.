namespace Takács_Krisztián_backend.Models.Dtos
{
    public record TantargyDto (int Id, string? TantargyNev, string? TantargyLeiras, ICollection<Jegyek> Jegyek);
    public record CreateTantargyDto (string? TantargyNev, string? TantargyLeiras);
    public record ModifyTantargyDto (string? TantargyNev, string? TantargyLeiras);
    public record RemoveTantargyDto (int Id);
}