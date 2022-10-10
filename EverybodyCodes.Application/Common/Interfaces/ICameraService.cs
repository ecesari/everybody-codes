using EverybodyCodes.Application.Camera;
using EverybodyCodes.Application.Models.Camera;

namespace EverybodyCodes.Application.Common.Interfaces
{
    public interface ICameraService
    {
        Task<IEnumerable<CameraViewModel>> GetAll();
        Task<IEnumerable<CameraViewModel>> GetByName(string name);
        Task<IEnumerable<CameraViewModel>> BulkAdd(List<CameraInsertCommand> insertCommands);
    }
}
