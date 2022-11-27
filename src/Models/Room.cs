using HogwartsHouses.Models.Types;

namespace HogwartsHouses.Models
{
    [System.Serializable]
    public class Room
    {
        public int Id { get; set; } = 0;
        public HouseType House { get; set; }
        public int MaxCapacity { get; set; }
        public int FreeBeds { get; set; }

        public Room(HouseType house, int maxCapacity)
        {
            Id = Id++;
            House = house;
            MaxCapacity = maxCapacity;
            FreeBeds = maxCapacity;    
        }
    }
}
