using HogwartsHouses.DAL;
using HogwartsHouses.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HogwartsHouses.Controllers
{
    [ApiController, Route("/")]
    public class GreetingController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public GreetingController(IRoomService RoomService)
        {
            _roomService = RoomService;
        }
        [HttpGet("{name?}")]
        public string Greeting(string name = "Witches and Wizards")
        {
            return $"Welcome to Hogwarts, {name}";
        }

        [HttpGet("rooms")]
        public List<Room> LocusOmnis()
        {
            return _roomService.ListAllRooms();
        }
    }
}
