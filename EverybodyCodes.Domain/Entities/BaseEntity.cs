using System.ComponentModel.DataAnnotations;

namespace EverybodyCodes.Domain.Entities
{
    public class BaseEntity
	{
		[Key]
		public int Id { get; set; }
	}
}
