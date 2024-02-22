namespace Takács_Krisztián_backend.Repositories.Interfaces
{
    public interface IJegyInterface
    {
        Task<IEnumerable<Jegyek>> GetAll();
        Task<Jegyek> GetById(int id);
        Task<JegyDto> Post(CreateJegyDto createJegyDto);
        Task<JegyDto> Put(int id, ModifyTanarDto modifyTanarDto);
        Task<JegyDto> DeleteById(int id);
    }
}