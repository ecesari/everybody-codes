using Microsoft.EntityFrameworkCore;


namespace EverybodyCodes.Application.Common.Interfaces
{
    internal interface ICameraDbContext
    {
        DbSet<Domain.Entities.Camera> Cameras { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
