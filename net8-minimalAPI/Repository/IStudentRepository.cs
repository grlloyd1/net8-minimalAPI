namespace net8_minimalAPI.Repository
{
    public interface IStudentRepository
    {
        public Task<List<Student>> Get();
        public Task<Student> Get(int id);
    }
}
