namespace Takács_Krisztián_backend.Models.Dtos
{
    public record TanarDto (int Id, string? VezetekNev, string? KeresztNev, string? Email, string? Nem, ICollection<Jegyek> Jegyek);
    public record CreateTanarDto (string? VezetekNev, string? KeresztNev, string? Email, string? Nem);
    public record ModifyTanarDto (string? VezetekNev, string? KeresztNev, string? Email, string? Nem);
    public record RemoveTanarDto (int Id);
}