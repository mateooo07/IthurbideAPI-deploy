using IthurbideAPI.Models;

namespace IthurbideAPI.Repositories;

public interface ISensorRepository
{
    Task AddReadingsAsync(IEnumerable<SensorReading> readings);
    Task<IEnumerable<SensorReading>> GetLastReadingsAsync(int limit);
}