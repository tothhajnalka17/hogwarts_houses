using System;
using System.Collections.Generic;
using HogwartsHouses.Models;
using HogwartsHouses.Models.Types;

namespace HogwartsHouses.DAL
{
    public class StudentSampler
    {
        public HashSet<Student> Students { get; private set; } = new HashSet<Student>();

        public StudentSampler()
        {
            Initialize();
        }

        public void Initialize()
        {
            var student1 = new Student("Hermione", "Granger", HouseType.Gryffindor, PetType.Cat);
            var student2 = new Student("Draco", "Malfoy", HouseType.Slytherin, PetType.Rat);

            Students.Add(student1);
            Students.Add(student2);

        }
    }
}
