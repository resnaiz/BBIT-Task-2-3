namespace test_code_rest_api.Models
{
    public class Apartment : Entity
    {
        public int Number { get; set; }
        public int Floor { get; set; }
        public int NumberOfRooms { get; set; }
        public int CitizenCount { get; set; }
        public double TotalArea { get; set; }
        public double LivingArea { get; set;}
        public int HouseId { get; set; }
        public House Houses { get; set; }
        public ICollection<Citizen> Citizens { get; set; }
    }
}
