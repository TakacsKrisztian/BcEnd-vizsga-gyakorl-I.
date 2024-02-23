namespace Takács_Krisztián_backend
{
    public static class Extensions
    {
        public static TanarDto AsDto(this Tanarok tanar)
        {
            return new TanarDto(tanar.Id, tanar.VezetekNev, tanar.KeresztNev, tanar.Email, tanar.Nem, tanar.Jegyek);
        }

        public static TantargyDto AsDto(this Tantargyak tantargy)
        {
            return new TantargyDto(tantargy.Id, tantargy.TantargyNev, tantargy.TantargyLeiras, tantargy.Jegyek);
        }

        public static JegyDto AsDto(this Jegyek jegy)
        {
            return new JegyDto(jegy.Id, jegy.JegySzammal, jegy.JegySzoveggel, jegy.BeirasDatuma, jegy.ModositasDatuma, jegy.IdTanarok, jegy.IdTantargyak, jegy.IdTanarokNavigation, jegy.IdTantargyakNavigation);
        }
    }
}