using System;
using System.Collections.Generic;
using HogwartsHouses.Models;
using HogwartsHouses.Models.Types;

namespace HogwartsHouses.DAL
{
    public class StudentSampler
    {
        public HashSet<Student> Students { get; private set; } = new HashSet<Student>();
        public IRoomService RoomService { get; private set; }

        public StudentSampler(IRoomService roomService)
        {
            Initialize();
            RoomService = roomService;
        }

        public void Initialize()
        {
            Room room1 = RoomService.FindRoom(1);
            Room room2 = RoomService.FindRoom(7);

            var student1 = new Student("Hermione", "Granger", HouseType.Gryffindor, PetType.Cat);
            var student2 = new Student("Draco", "Malfoy", HouseType.Slytherin, PetType.Rat);

            RoomService.AssignStudentToRoom(room1, student1);
            RoomService.AssignStudentToRoom(room2, student2);

            Students.Add(student1);
            Students.Add(student2);

        }
    }
}
