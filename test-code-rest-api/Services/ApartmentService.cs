using AutoMapper;
using Microsoft.EntityFrameworkCore;
using test_code_rest_api.Database;
using test_code_rest_api.Interfaces;
using test_code_rest_api.Models;
using test_code_rest_api.ModelsDTO;

namespace test_code_rest_api.Services
{
    public class ApartmentService : IApartmentService
    {
        private readonly IApiDbContext _context;
        private readonly IMapper _mapper;
 
        public ApartmentService(IApiDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<ApartmentDto> GetApartments()
        {
            var apartments = _context.Apartments.Include(x => x.Houses).ToList();

            var apartmentDto = _mapper.Map<IEnumerable<ApartmentDto>>(apartments);

            return apartmentDto;
        }

        public ApartmentDto GetApartment(int id)
        {
            var apartment = _context.Apartments.Include(x => x.Houses).FirstOrDefault(x => x.Id == id);

            var apartmentDto = _mapper.Map<ApartmentDto>(apartment);

            return apartmentDto;
        }

        public ApartmentDto CreateApartment(ApartmentDto apartmentDto)
        {
            var apartment = _mapper.Map<Apartment>(apartmentDto);

            _context.Apartments.Add(apartment);
            _context.SaveChanges();

            var createdApartmentDto = _mapper.Map<ApartmentDto>(apartment);

            return createdApartmentDto;
        }

        public ApartmentDto? UpdateApartment(int id, ApartmentDto apartmentDto)
        {
            var existingApartment = _context.Apartments.Include(x => x.Houses).FirstOrDefault(x => x.Id == id);

            if (existingApartment == null)
                return null;

            _mapper.Map(apartmentDto, existingApartment);
            _context.SaveChanges();

            var updatedApartmentDto = _mapper.Map<ApartmentDto>(existingApartment);

            return updatedApartmentDto;
        }

        public bool DeleteApartment(int id)
        {
            var apartment = _context.Apartments.FirstOrDefault(x => x.Id == id);

            if (apartment == null) return false;

            _context.Apartments.Remove(apartment);
            _context.SaveChanges();

            return true;
        }
    }
}
