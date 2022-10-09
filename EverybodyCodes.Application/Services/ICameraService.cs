using EverybodyCodes.Application.Camera;

namespace EverybodyCodes.Application.Services
{
    interface ICameraService
    {
        Task<IEnumerable<CameraViewModel>> GetAll();
    }
}
