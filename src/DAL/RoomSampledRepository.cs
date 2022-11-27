using HogwartsHouses.Models;
using HogwartsHouses.Models.Types;
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
            return RoomSampler.Rooms.ToList();
        }

        public List<Room> GetAllAvailable()
        {
            return RoomSampler.Rooms.Where((room) => room.FreeBeds > 0).ToList();
        }

        public List<Room> GetAllAvailableRatRooms()
        {
            List<Room> RatRooms = RoomSampler.Rooms.Where((room) => room.PetTypes.Contains(PetType.Rat) && room.FreeBeds > 0).ToList();
            return GetAll().Except(RatRooms).ToList();
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
