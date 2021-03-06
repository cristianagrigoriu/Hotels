using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private static IEnumerable<Room> AllRooms = new List<Room>
        {
            new Room
            {
                Id = new Guid("A3692988-BA65-49C7-867C-105E4622B371"),
                RoomNumber = "101",
                Price = 1000.0
            },
            new Room
            {
                Id = new Guid("CBC1860B-51CC-4FA4-BD12-5A477E6304B7"),
                RoomNumber = "201",
                Price = 2000.0
            },
            new Room
            {
                Id = new Guid("28AEA96E-1979-4278-AED3-BE3AD91A62C6"),
                RoomNumber = "202",
                Price = 2002.0
            },
            new Room
            {
                Id = new Guid("64AA5051-EDCC-4B09-A4FA-15AAC6E29842"),
                RoomNumber = "203",
                Price = 2002.5
            }
        };

        [HttpGet]
        public IEnumerable<Room> GetAllRooms()
        {
            return AllRooms;
        }
    }
}
