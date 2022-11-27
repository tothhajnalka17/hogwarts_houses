using HogwartsHouses.Models.Types;

namespace HogwartsHouses.Models
{
    [System.Serializable]
    public class Student
    {
        public static int idSeed { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public HouseType House { get; set; }
        public PetType Pet { get; set; }

        public Student(string firstName, string lastName, HouseType house, PetType pet)
        {
            this.Id = idSeed;
            idSeed++;
            FirstName = firstName;
            LastName = lastName;
            House = house;
            Pet = pet;
        }
    }
}
