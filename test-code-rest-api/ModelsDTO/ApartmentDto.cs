using System.ComponentModel.DataAnnotations;
using test_code_rest_api.Models;

namespace test_code_rest_api.ModelsDTO
{
    public class ApartmentDto : Entity
    {
        [Required]
        public int Number { get; set; }

        [Required]
        public int Floor { get; set; }

        [Required]
        public int NumberOfRooms { get; set; }

        [Required]
        public int CitizenCount { get; set; }

        [Required]
        public double TotalArea { get; set; }

        [Required]
        public double LivingArea { get; set; }
        
        [Required]
        public int HouseId { get; set; }
    }
}
