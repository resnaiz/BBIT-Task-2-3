using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using test_code_rest_api.Interfaces;
using test_code_rest_api.Models;
using test_code_rest_api.ModelsDTO;

namespace test_code_rest_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseController : ControllerBase
    {
        private readonly IHouseService _houseService;

        public HouseController(IHouseService houseService)
        {
            _houseService = houseService;
        }

        [HttpGet]
        public IActionResult GetHouses()
        {
            var houses = _houseService.GetHouses();

            return Ok(houses);
        }

        [HttpGet("{id}")]
        public IActionResult GetHouse(int id)
        {
            var house = _houseService.GetHouse(id);

            return Ok(house);
        }

        [HttpPost]
        public IActionResult CreateHouse(HouseDto houseDto)
        {
            var createdHouse = _houseService.CreateHouse(houseDto);

            return Ok(createdHouse);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateHouse(int id, HouseDto houseDto)
        {
            var updatedHouse = _houseService.UpdateHouse(id, houseDto);

            return Ok(updatedHouse);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteHouse(int id)
        {
            var house = _houseService.DeleteHouse(id);

            if (!house)
                return NotFound();

            return Ok(house);
        }
    }
}
        