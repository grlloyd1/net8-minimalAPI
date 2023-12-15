using net8_minimalAPI.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IStudentRepository, HardCodedStudentRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/students", async (IStudentRepository repository) => await repository.Get())
    .WithName("GetStudents")
    .WithOpenApi();

app.MapGet("/students/{id}", async (int id, IStudentRepository repository) => await repository.Get(id))
    .WithName("GetStudent")
    .WithOpenApi();

app.Run();
