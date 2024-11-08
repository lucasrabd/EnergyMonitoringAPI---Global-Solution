using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using EnergyMonitoringAPI.Models;
using EnergyMonitoringAPI.Services;

namespace EnergyMonitoringAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnergyController : ControllerBase
    {
        private readonly EnergyService _service;

        public EnergyController(EnergyService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var production = await _service.GetByIdAsync(id);
            if (production == null) return NotFound();
            return Ok(production);
        }

        [HttpPost]
        public async Task<IActionResult> Create(EnergyProduction production)
        {
            await _service.AddAsync(production);
            return CreatedAtAction(nameof(GetById), new { id = production.Id }, production);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, EnergyProduction production)
        {
            production.Id = id;
            await _service.UpdateAsync(production);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}

