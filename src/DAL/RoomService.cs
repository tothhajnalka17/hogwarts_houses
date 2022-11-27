using HogwartsHouses.Models;
using HogwartsHouses.Models.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace HogwartsHouses.DAL
{
    public class RoomService : IRoomService
    {
        private IRepository<Room> _repository { get; }

        public RoomService(IRepository<Room> repository)
        {
            _repository = repository;
        }

        public List<Room> ListAllRooms()
        {
            return _repository.GetAll();
        }

        public void AddRoom(Room room)
        {
            _repository.Insert(room);
        }

        public void AddRandomRoom()
        {
            Random rnd = new Random();
            int house = rnd.Next(1, 4);
            int maxCapacity = rnd.Next(1, 10);
            Room newRoom = new Room((HouseType)house, maxCapacity);
            AddRoom(newRoom);
        }

        public Room FindRoom(int id)
        {
            return _repository.Find(id);
        }

        public void DeleteRoom(int id)
        {
            _repository.Delete(FindRoom(id));
        }
    }
}
