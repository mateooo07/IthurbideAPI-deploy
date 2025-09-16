using IthurbideAPI.DTOs;
using IthurbideAPI.Models;
using AutoMapper;

namespace IthurbideAPI.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<SensorReadingDTO, SensorReading>()
            .ForMember(dest => dest.Timestamp,
                opt => opt.MapFrom(src => src.Timestamp ?? DateTime.UtcNow));
    }
}