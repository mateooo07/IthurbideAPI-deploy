using IthurbideAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace IthurbideAPI.DbContext;

public class IthurbideDBContext : Microsoft.EntityFrameworkCore.DbContext
{
    public IthurbideDBContext(DbContextOptions<IthurbideDBContext> options) : base(options) { }

    public DbSet<SensorReading> SensorReadings => Set<SensorReading>();
}