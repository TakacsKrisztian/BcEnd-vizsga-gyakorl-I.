using Takács_Krisztián_backend.Repositories.Interfaces;

namespace Takács_Krisztián_backend.Repositories.Services
{
    public class JegyService : IJegyInterface
    {
        private readonly OsztalynaploContext osztalynaploContext;

        public JegyService(OsztalynaploContext osztalynaploContext)
        {
            this.osztalynaploContext = osztalynaploContext;
        }

        public Task<JegyDto> Post(CreateJegyDto createJegyDto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Jegyek>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Jegyek> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<JegyDto> Put(int id, ModifyTanarDto modifyTanarDto)
        {
            throw new NotImplementedException();
        }

        public Task<JegyDto> DeleteById(int id)
        {
            throw new NotImplementedException();
        }
    }
}