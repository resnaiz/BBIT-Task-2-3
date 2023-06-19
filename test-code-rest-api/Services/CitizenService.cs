using AutoMapper;
using Microsoft.EntityFrameworkCore;
using test_code_rest_api.Database;
using test_code_rest_api.Interfaces;
using test_code_rest_api.Models;
using test_code_rest_api.ModelsDTO;

namespace test_code_rest_api.Services
{
    public class CitizenService : ICitizenService
    {
        private readonly IApiDbContext _context;
        private readonly IMapper _mapper;

        public CitizenService(IApiDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<CitizenDto> GetCitizens()
        {
            var citizens = _context.Citizens.Include(x => x.Apartment).ToList();

            var citizensDto = _mapper.Map<IEnumerable<CitizenDto>>(citizens);

            return citizensDto;
        }

        public CitizenDto GetCitizen(int id)
        {
            var citizen = _context.Citizens.Include(x => x.Apartment).FirstOrDefault(x => x.Id == id);

            var citizenDto = _mapper.Map<CitizenDto>(citizen);

            return citizenDto;
        }

        public CitizenDto CreateCitizen(CitizenDto citizenDto)
        {
            var citizen = _mapper.Map<Citizen>(citizenDto);

            _context.Citizens.Add(citizen);
            _context.SaveChanges();

            var createdCitizenDto = _mapper.Map<CitizenDto>(citizen);

            return createdCitizenDto;
        }

        public CitizenDto UpdateCitizen(int id, CitizenDto citizenDto)
        {
            var citizen = _context.Citizens.FirstOrDefault(x => x.Id == id);

            if (citizen == null)
                return null!;

            _mapper.Map(citizenDto, citizen);
            _context.SaveChanges();

            var updatedCitizenDto = _mapper.Map<CitizenDto>(citizen);

            return updatedCitizenDto;
        }

        public bool DeleteCitizen(int id)
        {
            var citizen = _context.Citizens.FirstOrDefault(x => x.Id == id);

            if (citizen == null) return false;

            _context.Citizens.Remove(citizen);
            _context.SaveChanges();

            return true;
        }
    }
}
