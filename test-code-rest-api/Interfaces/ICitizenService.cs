using test_code_rest_api.ModelsDTO;

namespace test_code_rest_api.Interfaces
{
    public interface ICitizenService
    {
        IEnumerable<CitizenDto> GetCitizens();
        CitizenDto GetCitizen(int id);
        CitizenDto CreateCitizen(CitizenDto residentDto);
        CitizenDto UpdateCitizen(int id, CitizenDto residentDto);
        bool DeleteCitizen(int id);
    }
}
