using System;
using System.Collections.Generic;
using HogwartsHouses.Models;
using HogwartsHouses.Models.Types;

namespace HogwartsHouses.DAL
{
    public class RoomSampler
    {
        public HashSet<Room> Rooms { get; private set; } = new HashSet<Room>();

        public RoomSampler()
        {
            Initialize();
        }

        public void Initialize()
        {
            var room1 = new Room((HouseType)1, 4);
            var room2 = new Room((HouseType)1, 6);
            var room3 = new Room((HouseType)2, 7);
            var room4 = new Room((HouseType)2, 4);
            var room5 = new Room((HouseType)3, 3);
            var room6 = new Room((HouseType)3, 6);
            var room7 = new Room((HouseType)4, 5);
            var room8 = new Room((HouseType)4, 4);
            Rooms.Add(room1);
            Rooms.Add(room2);
            Rooms.Add(room3);
            Rooms.Add(room4);
            Rooms.Add(room5);
            Rooms.Add(room6);
            Rooms.Add(room7);
            Rooms.Add(room8);
        }
    }
}
