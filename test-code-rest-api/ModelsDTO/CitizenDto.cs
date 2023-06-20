using System.ComponentModel.DataAnnotations;
using test_code_rest_api.Models;

namespace test_code_rest_api.ModelsDTO
{
    public class CitizenDto : Entity
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"^\d{6}-\d{5}$", ErrorMessage = "Invalid personal identity code format. Must be in the format '123456-12345'.")]
        public string PersonalIdentityCode { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [RegularExpression(@"^\+371\d{8}$", ErrorMessage = "Invalid phone number format.")]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        public int ApartmentId { get; set; }

        public bool IsOwner { get; set; }
    }
}
