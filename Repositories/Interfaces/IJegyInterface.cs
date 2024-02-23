namespace Takács_Krisztián_backend.Repositories.Interfaces
{
    public interface IJegyInterface
    {
        Task<IEnumerable<Jegyek>> GetAll();
        public string GetCount();
        Task<Jegyek> GetById(int id);
        Task<Jegyek> Post(CreateJegyDto createJegyDto);
        Task<Jegyek> Put(int id, ModifyJegyDto modifyJegyDto);
        Task<Jegyek> DeleteById(int id);
    }
}