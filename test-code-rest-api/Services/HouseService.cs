using AutoMapper;
using Microsoft.EntityFrameworkCore;
using test_code_rest_api.Database;
using test_code_rest_api.Interfaces;
using test_code_rest_api.Models;
using test_code_rest_api.ModelsDTO;

namespace test_code_rest_api.Services
{
    public class HouseService : IHouseService
    {
        private readonly IApiDbContext _context;
        private readonly IMapper _mapper;

        public HouseService(IApiDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IEnumerable<HouseDto> GetHouses()
        {
            var houses = _context.Houses.Include(x => x.Apartments).ToList();

            var housesDto = _mapper.Map<IEnumerable<HouseDto>>(houses);

            return housesDto;
        }

        public HouseDto GetHouse(int id)
        {
            var house = _context.Houses.Include(x => x.Apartments).FirstOrDefault(x => x.Id == id);

            var houseDto = _mapper.Map<HouseDto>(house);

            return houseDto;
        }

        public HouseDto CreateHouse(HouseDto houseDto)
        {
            var house = _mapper.Map<House>(houseDto);

            _context.Houses.Add(house);
            _context.SaveChanges();

            var createdHouseDto = _mapper.Map<HouseDto>(house);

            return createdHouseDto;
        }

        public HouseDto UpdateHouse(int id, HouseDto houseDto)
        {
            var house = _context.Houses.FirstOrDefault(x => x.Id == id);

            _mapper.Map(houseDto, house);
            _context.SaveChanges();

            var updatedHouseDto = _mapper.Map<HouseDto>(house);
            
            return updatedHouseDto;
        }

        public bool DeleteHouse(int id)
        {
            var house = _context.Houses.FirstOrDefault(x => x.Id == id);

            _context.Houses.Remove(house!);
            _context.SaveChanges();

            return true;
        }
    }
}
