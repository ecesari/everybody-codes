using AutoMapper;
using EverybodyCodes.Application.Camera;
using EverybodyCodes.Application.Models.Camera;
using System.Text.RegularExpressions;

namespace EverybodyCodes.Application.Common.Mappers
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Domain.Entities.Camera, CameraViewModel>()
                  .AfterMap((entity, vm) => vm.Code = Regex.Match(entity.Name.Split(" ").FirstOrDefault(), @"\d+")?.Value);

            CreateMap<CameraInsertCommand, Domain.Entities.Camera>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Camera));
        }
    }
}
