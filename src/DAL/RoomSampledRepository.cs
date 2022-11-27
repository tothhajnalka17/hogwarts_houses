using HogwartsHouses.Models;
using System.Collections.Generic;
using System.Linq;

namespace HogwartsHouses.DAL
{
    public class RoomSampledRepository : IRepository<Room>
    {
        public RoomSampler RoomSampler { get; }

        public RoomSampledRepository()
        {
            RoomSampler = new RoomSampler();
        }

        public List<Room> GetAll()
        {
            var RoomList = new List<Room>();
            foreach (var room in RoomSampler.Rooms)
            {
                RoomList.Add(room);
            }
            return RoomList;
        }

        public Room Find(int id)
        {
            return RoomSampler.Rooms.Where((room) => room.Id == id).First();
        }

        public void Insert(Room entity)
        {
            RoomSampler.Rooms.Add(entity);
        }

        public void Update(Room entity)
        {
            Room oldRoom = Find(entity.Id);
            oldRoom = entity;
        }

        public void Delete(Room entity)
        {
            RoomSampler.Rooms.Remove(entity);
        }
    }
}
