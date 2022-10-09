using AutoMapper;
using EverybodyCodes.Application.Camera;
using EverybodyCodes.Application.Models.Camera;
using EverybodyCodes.Domain.Repositories;
using EverybodyCodes.Domain.Specifications.CameraSpecifications;

namespace EverybodyCodes.Application.Services
{
    internal class CameraService : ICameraService
    {

        private readonly ICameraRepository cameraRepository;
        private readonly IMapper mapper;

        public CameraService(ICameraRepository cameraRepository, IMapper mapper)
        {
            this.cameraRepository = cameraRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<CameraViewModel>> GetAll()
        {
            var cameras = await cameraRepository.GetAllAsync();
            var viewModel = mapper.Map<List<CameraViewModel>>(cameras);
            return await Task.FromResult(viewModel);
        }

        public async Task<IEnumerable<CameraViewModel>> GetByName(string name)
        {
            var specification = new HasNameSpecification(name);
            var entities = await cameraRepository.GetAsync(specification);
            var viewModel = mapper.Map<List<CameraViewModel>>(entities);
            return await Task.FromResult(viewModel);
        }

        public async Task<IEnumerable<CameraViewModel>> BulkAdd(List<CameraInsertCommand> insertCommands)
        {
            var entities = mapper.Map<List<Domain.Entities.Camera>>(insertCommands);
            var cameras = await cameraRepository.AddBulkAsync(entities);
            var returnModel = mapper.Map<List<CameraViewModel>>(cameras);
            return await Task.FromResult(returnModel);
        }
    }
}
