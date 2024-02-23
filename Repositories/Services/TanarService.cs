using Microsoft.EntityFrameworkCore;
using Takács_Krisztián_backend.Models.Dtos;

namespace Takács_Krisztián_backend.Repositories.Services
{
    public class TanarService : ITanarInterface
    {
        private readonly OsztalynaploContext osztalynaploContext;

        public TanarService(OsztalynaploContext osztalynaploContext)
        {
            this.osztalynaploContext = osztalynaploContext;
        }

        public async Task<Tanarok> Post(CreateTanarDto createTanarDto)
        {
            var tanar = new Tanarok
            {
                VezetekNev = createTanarDto.VezetekNev,
                KeresztNev = createTanarDto.KeresztNev,
                Email = createTanarDto.Email,
                Nem = createTanarDto.Nem,
            };

            await osztalynaploContext.Tanaroks.AddAsync(tanar);
            await osztalynaploContext.SaveChangesAsync();
            return tanar;
        }

        public async Task<IEnumerable<Tanarok>> GetAll()
        {
            return await osztalynaploContext.Tanaroks.ToListAsync();
        }

        public async Task<Tanarok> GetById(int id)
        {
            return await osztalynaploContext.Tanaroks.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Tanarok> Put(int id, ModifyTanarDto modifyTanarDto)
        {
            var tanar = new Tanarok
            {
                VezetekNev = modifyTanarDto.VezetekNev,
                KeresztNev = modifyTanarDto.KeresztNev,
                Email = modifyTanarDto.Email,
                Nem = modifyTanarDto.Nem,
            };

            osztalynaploContext.Update(tanar);
            await osztalynaploContext.SaveChangesAsync();

            return tanar;
        }

        public async Task<Tanarok> DeleteById(int id)
        {
            var tanar = await osztalynaploContext.Tanaroks.FirstOrDefaultAsync(x => x.Id == id);

            if (tanar != null)
            {
                osztalynaploContext.Tanaroks.Remove(tanar);
                await osztalynaploContext.SaveChangesAsync();
            }

            return tanar;
        }
    }
}