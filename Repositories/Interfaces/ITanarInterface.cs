namespace Takács_Krisztián_backend.Repositories.Interfaces
{
    public interface ITanarInterface
    {
        Task<IEnumerable<Tanarok>> GetAll();
        Task<Tanarok> GetById(int id);
        Task<Tanarok> Post(CreateTanarDto createTanarDto);
        Task<Tanarok> Put(int id, ModifyTanarDto modifyTanarDto);
        Task<Tanarok> DeleteById(int id);
    }
}