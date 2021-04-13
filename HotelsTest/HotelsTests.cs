using System.Linq;
using FluentAssertions;
using Hotels.Controllers;
using NUnit.Framework;

namespace HotelsTest
{
    public class HotelsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void When_getting_all_rooms_Then_room_count_should_be_3()
        {
            var hotelController = new HotelController();
            hotelController.GetAllRooms().Count().Should().Be(4);
        }
    }
}