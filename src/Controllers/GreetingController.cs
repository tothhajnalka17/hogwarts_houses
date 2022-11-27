using HogwartsHouses.DAL;
using HogwartsHouses.Models;
using Microsoft.AspNetCore.Mvc;
using System;
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

        [HttpPost("rooms")]
        public void LocusNovus()
        {
            _roomService.AddRandomRoom();
        }

        [HttpGet("rooms/{id}")]
        public Room InvenioLocus(int id)
        {
            return _roomService.FindRoom(id);
        }
    }
}
