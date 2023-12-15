using net8_minimalAPI.Models;
using net8_minimalAPI.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IGenericRepository<Student>, HardCodedStudentRepository>();
builder.Services.AddScoped<IGenericRepository<Course>, HardCodedCourseRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/students", async (IGenericRepository<Student> repository) => await repository.Get())
    .WithName("GetStudents")
    .WithOpenApi();

app.MapGet("/students/{id}", async (int id, IGenericRepository<Student> repository) => await repository.Get(id))
    .WithName("GetStudent")
    .WithOpenApi();

app.MapGet("/courses", async (IGenericRepository<Course> repository) => await repository.Get())
    .WithName("GetCourses")
    .WithOpenApi();

app.MapGet("/courses/{id}", async (int id, IGenericRepository<Course> repository) => await repository.Get(id))
    .WithName("GetCourse")
    .WithOpenApi();

app.Run();
