namespace test_code_rest_api.ModelsDTO
{
    public class CitizenDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalIdentityCode { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int ApartmentId { get; set; }
        public bool IsOwner { get; set; }
    }
}
