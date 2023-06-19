using Microsoft.AspNetCore.Mvc;
using test_code_rest_api.Interfaces;
using test_code_rest_api.ModelsDTO;

namespace test_code_rest_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentController : ControllerBase
    {
        private readonly IApartmentService _apartmentService;

        public ApartmentController(IApartmentService apartmentService)
        {
            _apartmentService = apartmentService;
        }

        [HttpGet]
        public IActionResult GetApartments()
        {
            var apartments = _apartmentService.GetApartments();
            return Ok(apartments);
        }

        [HttpGet("{id}")]
        public IActionResult GetApartment(int id)
        {
            var apartment = _apartmentService.GetApartment(id);
            return Ok(apartment);
        }

        [HttpPost]
        public IActionResult CreateApartment(ApartmentDto apartmentDto)
        {
            var createdApartment = _apartmentService.CreateApartment(apartmentDto);

            return Created("", createdApartment);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateApartment(int id, ApartmentDto apartmentDto)
        {
            var updatedApartment = _apartmentService.UpdateApartment(id, apartmentDto);

            return Ok(updatedApartment);
        }

        [HttpDelete]
        public IActionResult DeleteApartment(int id)
        {
            var result = _apartmentService.DeleteApartment(id);

            if (!result)
                return NotFound();

            return NoContent();
        }
    }
}
