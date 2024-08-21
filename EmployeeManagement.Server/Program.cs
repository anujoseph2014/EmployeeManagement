using EmployeeManagement.Server.DataAccess.Context;
using EmployeeManagement.Server.DataAccess.Interfaces;
using EmployeeManagement.Server.DataAccess.Repositories;


var builder = WebApplication.CreateBuilder(args);

// Define a CORS policy
builder.Services.AddCors(options => { options.AddPolicy("AllowLocalhost", 
    builder => builder .WithOrigins("http://localhost:4200") // Specify the allowed origin(s)
    .AllowAnyMethod() // Allow specific methods or use
    .WithMethods("GET", "POST") 
    .AllowAnyHeader() // Allow specific headers or use
    .WithHeaders("Content-Type") 
    .AllowCredentials()); // If credentials are needed 
    });

// Add services to the container.

builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddSqlite<EmployeeContext>("DataSource=Employee.db;Mode=ReadWrite");
builder.Services.AddScoped<IEmployeeRepository,EmployeeRepository>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseCors("AllowLocalhost");
app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
