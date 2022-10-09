using Microsoft.EntityFrameworkCore;

namespace EverybodyCodes.Infrastructure { 
	public class CameraDbContext : DbContext
	{
		public CameraDbContext(DbContextOptions<CameraDbContext> options) : base(options) { }
		public DbSet<Domain.Entities.Camera> Cameras { get; set; }	
	}
}
