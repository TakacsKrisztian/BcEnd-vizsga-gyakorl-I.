using Microsoft.EntityFrameworkCore;
using Takács_Krisztián_backend.Models.Dtos;

namespace Takács_Krisztián_backend.Repositories.Services
{
    public class TantargyService : ITantargyInterface
    {
        private readonly OsztalynaploContext osztalynaploContext;

        public TantargyService(OsztalynaploContext osztalynaploContext)
        {
            this.osztalynaploContext = osztalynaploContext;
        }

        public async Task<Tantargyak> Post(CreateTantargyDto createTantargyDto)
        {
            var tantargy = new Tantargyak
            {
                TantargyNev = createTantargyDto.TantargyNev,
                TantargyLeiras = createTantargyDto.TantargyLeiras,
            };

            await osztalynaploContext.Tantargyaks.AddAsync(tantargy);
            await osztalynaploContext.SaveChangesAsync();
            return tantargy;
        }

        public async Task<IEnumerable<Tantargyak>> GetAll()
        {
            return await osztalynaploContext.Tantargyaks.ToListAsync();
        }

        public async Task<Tantargyak> GetById(int id)
        {
            return await osztalynaploContext.Tantargyaks.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Tantargyak> Put(int id, ModifyTantargyDto modifyTantargyDto)
        {
            var tantargy = new Tantargyak
            {
                TantargyNev = modifyTantargyDto.TantargyNev,
                TantargyLeiras = modifyTantargyDto.TantargyLeiras,
            };

            osztalynaploContext.Update(tantargy);
            await osztalynaploContext.SaveChangesAsync();

            return tantargy;
        }

        public async Task<Tantargyak> DeleteById(int id)
        {
            var tantargy = await osztalynaploContext.Tantargyaks.FirstOrDefaultAsync(x => x.Id == id);

            if (tantargy != null)
            {
                osztalynaploContext.Tantargyaks.Remove(tantargy);
                await osztalynaploContext.SaveChangesAsync();
            }

            return tantargy;
        }
    }
}