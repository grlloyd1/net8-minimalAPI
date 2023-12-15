namespace net8_minimalAPI.Repository
{
    public interface IGenericRepository<T>
    {
        Task<T> Get(int id);
        Task<List<T>> Get();
    }
}
