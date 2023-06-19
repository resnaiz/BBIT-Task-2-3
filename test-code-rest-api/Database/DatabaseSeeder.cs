using test_code_rest_api.Models;

namespace test_code_rest_api.Database
{
    public class DatabaseSeeder
    {
        public static void SeedData(ApiDbContext dbContext)
        {
            if (dbContext.Houses.Any() || dbContext.Apartments.Any() || dbContext.Citizens.Any())
            {
                return; 
            }

            var houses = new List<House>
            {
                new House { Number = 1, Street = "Street 1", City = "City 1", Country = "Country 1", PostalCode = "12345" },
                new House { Number = 2, Street = "Street 2", City = "City 2", Country = "Country 2", PostalCode = "67890" }
            };

            dbContext.Houses.AddRange(houses);
            dbContext.SaveChanges();

            var apartments = new List<Apartment>
            {
                new Apartment { Number = 101, Floor = 1, NumberOfRooms = 3, CitizenCount = 2, TotalArea = 100.0, LivingArea = 80.0, HouseId = 1 },
                new Apartment { Number = 102, Floor = 1, NumberOfRooms = 2, CitizenCount = 1, TotalArea = 80.0, LivingArea = 60.0, HouseId = 1 },
                new Apartment { Number = 201, Floor = 2, NumberOfRooms = 4, CitizenCount = 3, TotalArea = 120.0, LivingArea = 100.0, HouseId = 2 }
            };

            dbContext.Apartments.AddRange(apartments);
            dbContext.SaveChanges();

            var citizens = new List<Citizen>
            {
                new Citizen { FirstName = "John", LastName = "Doe", PersonalIdentityCode = 123456789, YearOfBirth = new DateTime(1980, 1, 1), PhoneNumber = "123456789", EmailAddress = "john.doe@example.com", IsOwner = true, ApartmentId = 1 },
                new Citizen { FirstName = "Jane", LastName = "Smith", PersonalIdentityCode = 987654321, YearOfBirth = new DateTime(1990, 1, 1), PhoneNumber = "987654320", EmailAddress = "jane.smith@example.com", IsOwner = false, ApartmentId = 1 },
                new Citizen { FirstName = "Alice", LastName = "Johnson", PersonalIdentityCode = 456789123, YearOfBirth = new DateTime(1985, 1, 1), PhoneNumber = "456789130", EmailAddress = "alice.johnson@example.com", IsOwner = true, ApartmentId = 2 },
                new Citizen { FirstName = "Bob", LastName = "Williams", PersonalIdentityCode = 789123456, YearOfBirth = new DateTime(1975, 1, 1), PhoneNumber = "789123456", EmailAddress = "bob.williams@example.com", IsOwner = true, ApartmentId = 3 }
            };

            dbContext.Citizens.AddRange(citizens);
            dbContext.SaveChanges();
        }
    }
}