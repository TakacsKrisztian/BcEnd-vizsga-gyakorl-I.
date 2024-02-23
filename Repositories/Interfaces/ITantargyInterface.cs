namespace Takács_Krisztián_backend.Repositories.Interfaces
{
    public interface ITantargyInterface
    {
        Task<IEnumerable<Tantargyak>> GetAll();
        Task<Tantargyak> GetById(int id);
        Task<Tantargyak> Post(CreateTantargyDto createTantargyDto);
        Task<Tantargyak> Put(int id, ModifyTantargyDto modifyTantargyDto);
        Task<Tantargyak> DeleteById(int id);
    }
}