 using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using ToDoMVCtutorial.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

//SQL connectionString, not sure if this is the correct way to do it yet
builder.Services.AddDbContext<TodoContext>(opt =>
    opt.UseSqlServer("Server=LIBRALEX2\\SQL2017; Database=ToDoItems; User=VetMasterUser; Password=Vet12345#;"));

//builder.Services.AddDbContext<TodoContext>(opt =>
//    opt.UseSqlServer(builder.Configuration.GetConnectionString("ToDoItemsDatabase")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
   // app.UseSwagger();
    //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ToDoMVCtutorial v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run("http://localhost:5002");
