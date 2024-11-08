using System.Collections.Generic;
using System.Threading.Tasks;
using EnergyMonitoringAPI.Models;
using EnergyMonitoringAPI.Repositories;

namespace EnergyMonitoringAPI.Services
{
    public class EnergyService
    {
        private readonly IEnergyRepository _repository;

        public EnergyService(IEnergyRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<EnergyProduction>> GetAllAsync() => await _repository.GetAllAsync();
        public async Task<EnergyProduction> GetByIdAsync(string id) => await _repository.GetByIdAsync(id);
        public async Task AddAsync(EnergyProduction production) => await _repository.AddAsync(production);
        public async Task UpdateAsync(EnergyProduction production) => await _repository.UpdateAsync(production);
        public async Task DeleteAsync(string id) => await _repository.DeleteAsync(id);
    }
}
