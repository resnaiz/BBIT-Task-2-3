using test_code_rest_api.Models;
using test_code_rest_api.ModelsDTO;

namespace test_code_rest_api.Interfaces
{
    public interface IHouseService
    {
        IEnumerable<HouseDto> GetHouses();
        HouseDto GetHouse(int id);
        HouseDto CreateHouse(HouseDto houseDto);
        HouseDto UpdateHouse(int id, HouseDto houseDto);
        bool DeleteHouse(int id);
    }
}
