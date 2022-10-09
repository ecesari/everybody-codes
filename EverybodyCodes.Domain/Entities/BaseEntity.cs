using System.ComponentModel.DataAnnotations;

namespace EverybodyCodes.Domain.Entities
{
    public class BaseEntity
	{
		[Key]
		public Guid Id { get; set; }
	}
}
