namespace Takács_Krisztián_backend.Repositories.Interfaces
{
    public interface ITanarInterface
    {
        Task<IEnumerable<Tanarok>> GetAll();
        Task<Tanarok> GetById(int id);
        Task<TanarDto> Post(CreateTanarDto createTanarDto);
        Task<TanarDto> Put(int id, ModifyTanarDto modifyTanarDto);
        Task<Tanarok> DeleteById(int id);
    }
}