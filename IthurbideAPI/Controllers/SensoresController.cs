using AutoMapper;
using IthurbideAPI.DTOs;
using IthurbideAPI.Models;
using IthurbideAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace IthurbideAPI.Controllers;

[ApiController]
[Route("api/readings")]
public class SensoresController : ControllerBase
{
    private readonly ISensorRepository _repo;
    private readonly IMapper _mapper;

    public SensoresController(ISensorRepository repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] List<SensorReadingDTO> readings)
    {
        if (readings == null || readings.Count == 0)
            return BadRequest();

        var entities = readings.Select(r => _mapper.Map<SensorReading>(r));
        await _repo.AddReadingsAsync(entities);

        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] int limit = 50)
    {
        var last = await _repo.GetLastReadingsAsync(limit);
        return Ok(last);
    }
}