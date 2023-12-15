using net8_minimalAPI.Models;

namespace net8_minimalAPI.Repository
{
    public interface ICourseRepository
    {
        public Task<List<Course>> Get();
        public Task<Course> Get(int id);
    }
}
