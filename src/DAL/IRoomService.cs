using HogwartsHouses.Models;
using System.Collections.Generic;

namespace HogwartsHouses.DAL
{
    public interface IRoomService
    {
        public List<Room> ListAllRooms();
        public void AddRoom(Room room);
        public void AddRandomRoom();
        public Room FindRoom(int id);
        public void DeleteRoom(int id);
        public void UpdateRoom(Room roomToUpdate, Room updatedRoom);
    }
}
