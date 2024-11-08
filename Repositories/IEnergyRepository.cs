using System.Collections.Generic;
using System.Threading.Tasks;
using EnergyMonitoringAPI.Models;

namespace EnergyMonitoringAPI.Repositories
{
    public interface IEnergyRepository
    {
        Task<IEnumerable<EnergyProduction>> GetAllAsync();
        Task<EnergyProduction> GetByIdAsync(string id);
        Task AddAsync(EnergyProduction production);
        Task UpdateAsync(EnergyProduction production);
        Task DeleteAsync(string id);
    }
}
