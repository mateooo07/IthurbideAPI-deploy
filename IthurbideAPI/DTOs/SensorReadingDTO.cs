namespace IthurbideAPI.DTOs;

public class SensorReadingDTO
{
    public string Esp32Mac { get; set; } = null!;
    public DateTime? Timestamp { get; set; }
    public double Temperature { get; set; }
    public double Voltage { get; set; }
    public double Amperage { get; set; }

}