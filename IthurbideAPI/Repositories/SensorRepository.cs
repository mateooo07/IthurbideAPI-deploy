using IthurbideAPI.DbContext;
using IthurbideAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace IthurbideAPI.Repositories;

public class SensorRepository : ISensorRepository
{
    private readonly IthurbideDBContext _db;

    public SensorRepository(IthurbideDBContext db)
    {
        _db = db;
    }

    public async Task AddReadingsAsync(IEnumerable<SensorReading> readings)
    {
        await _db.SensorReadings.AddRangeAsync(readings);
        await _db.SaveChangesAsync();
    }

    public async Task<IEnumerable<SensorReading>> GetLastReadingsAsync(int limit)
    {
        return await _db.SensorReadings
            .OrderByDescending(r => r.Timestamp)
            .Take(limit)
            .ToListAsync();
    }
}