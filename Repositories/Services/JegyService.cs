using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Takács_Krisztián_backend.Models.Dtos;

namespace Takács_Krisztián_backend.Repositories.Services
{
    public class JegyService : IJegyInterface
    {
        private readonly OsztalynaploContext osztalynaploContext;

        public JegyService(OsztalynaploContext osztalynaploContext)
        {
            this.osztalynaploContext = osztalynaploContext;
        }

        public async Task<Jegyek> Post(CreateJegyDto createJegyDto)
        {
            var jegy = new Jegyek
            {
                JegySzammal = createJegyDto.JegySzammal,
                JegySzoveggel = createJegyDto.JegySzoveggel,
                IdTanarok = createJegyDto.IdTanarok,
                IdTantargyak = createJegyDto.IdTantargyak,
            };

            await osztalynaploContext.Jegyeks.AddAsync(jegy);
            await osztalynaploContext.SaveChangesAsync();
            return jegy;
        }

        public async Task<IEnumerable<Jegyek>> GetAll()
        {
            return await osztalynaploContext.Jegyeks.ToListAsync();
        }

        public string GetCount()
        {
            return "Összes jegy száma: " + osztalynaploContext.Jegyeks.Count();
        }

        public async Task<Jegyek> GetById(int id)
        {
            return await osztalynaploContext.Jegyeks.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Jegyek> Put(int id, ModifyJegyDto modifyJegyDto)
        {
            var jegy = new Jegyek
            {
                JegySzammal = modifyJegyDto.JegySzammal,
                JegySzoveggel = modifyJegyDto.JegySzoveggel,
                IdTanarok = modifyJegyDto.IdTanarok,
                IdTantargyak = modifyJegyDto.IdTantargyak,
            };

            osztalynaploContext.Update(jegy);
            await osztalynaploContext.SaveChangesAsync();

            return jegy;
        }

        public async Task<Jegyek> DeleteById(int id)
        {
            var jegy = await osztalynaploContext.Jegyeks.FirstOrDefaultAsync(x => x.Id == id);

            if (jegy != null)
            {
                osztalynaploContext.Jegyeks.Remove(jegy);
                await osztalynaploContext.SaveChangesAsync();
            }

            return jegy;
        }
    }
}