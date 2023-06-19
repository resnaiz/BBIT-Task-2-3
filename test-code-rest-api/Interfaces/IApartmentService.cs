using test_code_rest_api.ModelsDTO;

namespace test_code_rest_api.Interfaces
{
    public interface IApartmentService
    {
        IEnumerable<ApartmentDto> GetApartments();
        ApartmentDto GetApartment(int id);
        ApartmentDto CreateApartment(ApartmentDto apartmentDto);
        ApartmentDto? UpdateApartment(int id, ApartmentDto apartmentDto);
        bool DeleteApartment(int id);
    }
}
