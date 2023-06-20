using System.ComponentModel.DataAnnotations;
using test_code_rest_api.Models;

namespace test_code_rest_api.ModelsDTO
{
    public class HouseDto : Entity
    {
        [Required]
        public int Number { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string City { get; set; }
        
        [Required]
        public string Country { get; set; }
        
        [Required]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Invalid postal code.")]
        public string PostalCode { get; set; }
    }
}
