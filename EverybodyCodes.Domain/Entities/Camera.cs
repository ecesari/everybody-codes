namespace EverybodyCodes.Domain.Entities
{
    public class Camera : BaseEntity
    {
        public string Name { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }


		public static Camera Create(int id, string name, double latitude, double longitude)
		{
			return new Camera
			{
				Id = id,
				Name = name,
				Latitude = latitude,
				Longitude = longitude,
			};
		}
	}
}
