namespace EnergyMonitoringAPI.Models
{
    public class User
    {
        public string Id { get; set; } = string.Empty; // Valor padrão para evitar null
        public string Name { get; set; } = string.Empty; // Valor padrão para evitar null
        public string Role { get; set; } = string.Empty; // Valor padrão para evitar null
        public string Email { get; set; } = string.Empty; // Valor padrão para evitar null
        public string PasswordHash { get; set; } = string.Empty; // Valor padrão para evitar null
    }
}
