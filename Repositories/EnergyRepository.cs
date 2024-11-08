using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using EnergyMonitoringAPI.Models;
using EnergyMonitoringAPI.Data;

namespace EnergyMonitoringAPI.Repositories
{
    public class EnergyRepository : IEnergyRepository
    {
        private readonly MongoDbContext _context;

        public EnergyRepository(MongoDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EnergyProduction>> GetAllAsync() =>
            await _context.EnergyProductions.Find(_ => true).ToListAsync();

        public async Task<EnergyProduction> GetByIdAsync(string id) =>
            await _context.EnergyProductions.Find(e => e.Id == id).FirstOrDefaultAsync();

        public async Task AddAsync(EnergyProduction production) =>
            await _context.EnergyProductions.InsertOneAsync(production);

        public async Task UpdateAsync(EnergyProduction production) =>
            await _context.EnergyProductions.ReplaceOneAsync(e => e.Id == production.Id, production);

        public async Task DeleteAsync(string id) =>
            await _context.EnergyProductions.DeleteOneAsync(e => e.Id == id);
    }
}
