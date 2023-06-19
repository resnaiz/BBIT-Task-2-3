namespace test_code_rest_api.Models
{
    public class House : Entity
    {
        public int Number { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public ICollection<Apartment> Apartments { get; set; }
    }
}
