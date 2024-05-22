using EMSApi.Data;
using EMSApi.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EMSDbContext>();

// we are configuring EmployeeRepoitoryInMem injected where ever needed using DI 
//builder.Services.AddSingleton<IEmployeeRepo, EmployeeRepositoryInMem>();
builder.Services.AddScoped<IEmployeeRepo, EmployeeRepositoryMSSQL>();
//builder.Services.AddTransient<IEmployeeRepo, EmployeeRepositoryMSSQL>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var serviceScope = app.Services.CreateScope())
{
    // if db exist and up to date migrations are applied then dont apply.
    serviceScope.ServiceProvider.GetService<EMSDbContext>().Database.Migrate();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
