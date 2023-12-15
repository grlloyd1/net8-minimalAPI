namespace net8_minimalAPI.Repository
{
    public class HardCodedStudentRepository : IStudentRepository
    {
        List<Student> students = new()
        {
            new Student()
            {
                Id= 1,
                Name = "Mario",
                Surname = "Rossi",
                Email = "mario.rossi@southwales.ac.uk"
            },
            new Student()
            {
                Id= 2,
                Name = "Steve",
                Surname = "Rossi",
                Email = "steve.rossi@southwales.ac.uk"
            }
        };
        public Task<List<Student>> Get() { return Task.FromResult(students); }
        public Task<Student> Get(int id)
        {
            var student =  students.FirstOrDefault(s => s.Id == id);
            return Task.FromResult(student);
        }
    }
}
