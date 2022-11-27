using HogwartsHouses.Models;
using System.Collections.Generic;

namespace HogwartsHouses.DAL
{
    public interface IRoomService
    {
        public List<Room> ListAllRooms();
        public void AddRoom(Room room);
        public void AddRandomRoom();
    }
}
