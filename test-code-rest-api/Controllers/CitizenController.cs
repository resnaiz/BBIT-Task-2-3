using Microsoft.AspNetCore.Mvc;
using test_code_rest_api.Interfaces;
using test_code_rest_api.ModelsDTO;

namespace test_code_rest_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitizenController : ControllerBase
    {
        private readonly ICitizenService _citizenService;

        public CitizenController(ICitizenService citizenService)
        {
            _citizenService = citizenService;
        }

        [HttpGet]
        public IActionResult GetCitizens()
        {
            var citizens = _citizenService.GetCitizens();

            return Ok(citizens);
        }

        [HttpGet("{id}")]
        public IActionResult GetCitizen(int id)
        {
            var citizen = _citizenService.GetCitizen(id);

            return Ok(citizen);
        }

        [HttpPost]
        public IActionResult CreateCitizen(CitizenDto citizenDto)
        {
            var createdCitizen = _citizenService.CreateCitizen(citizenDto);

            return Created("", createdCitizen);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCitizen(int id, CitizenDto citizenDto)
        {
            var updatedCitizen = _citizenService.UpdateCitizen(id, citizenDto);

            return Ok(updatedCitizen);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCitizen(int id)
        {
            var result = _citizenService.DeleteCitizen(id);

            if (!result)
                return NotFound();
            
            return Ok(result);
        }
    }
}
