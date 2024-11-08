using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using EnergyMonitoringAPI.Models;

namespace EnergyMonitoringAPI.Data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("MongoDb"));
            _database = client.GetDatabase("EnergyMonitoringDB"); // Nome do banco de dados
        }

        public IMongoCollection<EnergyProduction> EnergyProductions => _database.GetCollection<EnergyProduction>("EnergyProductions");
        public IMongoCollection<User> Users => _database.GetCollection<User>("Users");
    }
}
