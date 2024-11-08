using EnergyMonitoringAPI.Data;
using EnergyMonitoringAPI.Repositories;
using EnergyMonitoringAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register dependencies
builder.Services.AddSingleton<MongoDbContext>();
builder.Services.AddScoped<IEnergyRepository, EnergyRepository>();
builder.Services.AddScoped<EnergyService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
