using HogwartsHouses.Models.Types;

namespace HogwartsHouses.Models
{
    [System.Serializable]
    public class Room
    {
        public static int IdSeed { get; set; } = 0;
        public int Id { get; set; }
        public HouseType House { get; set; }
        public int MaxCapacity { get; set; }
        public int FreeBeds { get; set; }

        public Room(HouseType house, int maxCapacity)
        {
            this.Id = IdSeed;
            IdSeed++;
            House = house;
            MaxCapacity = maxCapacity;
            FreeBeds = maxCapacity;    
        }
    }
}
