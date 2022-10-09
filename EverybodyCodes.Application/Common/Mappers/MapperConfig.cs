using AutoMapper;
using EverybodyCodes.Application.Camera;
using System.Text.RegularExpressions;

namespace EverybodyCodes.Application.Common.Mappers
{
    internal class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Domain.Entities.Camera, CameraViewModel>()
                  .AfterMap((entity, vm) => vm.Code = Regex.Match(entity.Name.Split(" ").FirstOrDefault(), @"\d+")?.Value);
        }
    }
}
