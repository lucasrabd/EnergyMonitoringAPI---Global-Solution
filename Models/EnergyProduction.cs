namespace EnergyMonitoringAPI.Models
{
    public class EnergyProduction
    {
        public string Id { get; set; } = string.Empty; // Valor padrão para evitar null
        public string Source { get; set; } = string.Empty; // Valor padrão para evitar null
        public DateTime Timestamp { get; set; } = DateTime.UtcNow; // Valor padrão
        public double Production { get; set; }
        public double Temperature { get; set; }
        public double WindSpeed { get; set; }
        public double SolarRadiation { get; set; }
    }
}
