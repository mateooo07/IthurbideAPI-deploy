using System.ComponentModel.DataAnnotations;

namespace IthurbideAPI.Models;

public class SensorReading
{ 
        public int Id { get; set; }
        [Required]
        public string Esp32Mac { get; set; } = null!;
        public DateTime Timestamp { get; set; }
        public double Temperature { get; set; }
        public double Voltage { get; set; }
        public double Amperage { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}