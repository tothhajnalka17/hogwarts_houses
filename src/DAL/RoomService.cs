using HogwartsHouses.Models;
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
            throw new NotImplementedException();
        }
    }
}
