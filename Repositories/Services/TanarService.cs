using Takács_Krisztián_backend.Repositories.Interfaces;

namespace Takács_Krisztián_backend.Repositories.Services
{
    public class TanarService : ITanarInterface
    {
        private readonly OsztalynaploContext osztalynaploContext;

        public JegyService(OsztalynaploContext osztalynaploContext)
        {
            this.osztalynaploContext = osztalynaploContext;
        }

        public Task<TanarDto> Post(CreateTanarDto createTanarDto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Tanarok>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Tanarok> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Tanarok> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        

        

        public Task<TanarDto> Put(int id, ModifyTanarDto modifyTanarDto)
        {
            throw new NotImplementedException();
        }
    }
}