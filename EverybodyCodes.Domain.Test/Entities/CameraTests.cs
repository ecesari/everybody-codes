using EverybodyCodes.Domain.Entities;
using System;
using Xunit;

namespace EverybodyCodes.Domain.Test
{
    public class CameraTests
    {
        private Guid _id = Guid.NewGuid();
        private string _name = "UTR-CM-501 Neude rijbaan voor Postkantoor";
        private double _longitude = 52.093421;
        private double _latitude = 5.118278;


        [Fact]
        public void Create_Camera()
        {
            var camera = Camera.Create(_id,_name,_latitude,_longitude);

            Assert.Equal(_id, camera.Id);
            Assert.Equal(_name, camera.Name);
            Assert.Equal(_longitude, camera.Longitude);
            Assert.Equal(_latitude, camera.Latitude);
        }
    }
}