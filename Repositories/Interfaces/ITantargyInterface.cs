namespace Takács_Krisztián_backend.Repositories.Interfaces
{
    public interface ITantargyInterface
    {
        Task<IEnumerable<Tantargyak>> GetAll();
        Task<Tantargyak> GetById(int id);
        Task<TantargyDto> Post(CreateTantargyDto createTantargyDto);
        Task<TantargyDto> Put(int id, ModifyTantargyDto modifyTantargyDto);
        Task<Tantargyak> DeleteById(int id);
    }
}