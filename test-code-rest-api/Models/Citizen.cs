namespace test_code_rest_api.Models
{
    public class Citizen : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalIdentityCode { get; set; }
        public DateTime YearOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public bool IsOwner { get; set; }
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
    }
}
