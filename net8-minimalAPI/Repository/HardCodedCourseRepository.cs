using net8_minimalAPI.Models;

namespace net8_minimalAPI.Repository
{
    public class HardCodedCourseRepository : IGenericRepository<Course>
    {
        List<Course> courses = new()
        {
            new Course
            {
                Id = 1,
                Name = "Bsc (Hons) Computing",
                Description = "A Computing Course"
            },
            new Course
            {
                Id = 2,
                Name = "Bsc (Hons) Football",
                Description = "A Football Course"
            },
        };
        public Task<List<Course>> Get()
        {
            return Task.FromResult(courses);
        }
        public Task<Course> Get(int id)
        {
            var course = courses.FirstOrDefault(c => c.Id == id);
            return Task.FromResult(course);
        }
    }
}
