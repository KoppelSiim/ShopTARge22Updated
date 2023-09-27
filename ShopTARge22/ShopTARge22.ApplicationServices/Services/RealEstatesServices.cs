using Microsoft.EntityFrameworkCore;
using ShopTARge22.Core.Domain;
using ShopTARge22.Core.Dto;
using ShopTARge22.Core.ServiceInterface;
using ShopTARge22.Data;

namespace ShopTARge22.ApplicationServices.Services
{
    public class RealestatesServices : IRealestateServices

    {
        private readonly ShopTARge22Context _context;

        public RealestatesServices(ShopTARge22Context context)
        {
            _context = context;
        }

        public async Task<Realestate> Create(RealestateDto dto)
        {
            Realestate realestate = new Realestate();

            realestate.Id = Guid.NewGuid();
            realestate.Address = dto.Address;
            realestate.SizeSqrM = dto.SizeSqrM;
            realestate.RoomCount = dto.RoomCount;
            realestate.Floor = dto.Floor;
            realestate.BuildingType = dto.BuildingType;
            realestate.BuiltInYear = dto.BuiltInYear;
            realestate.CreatedAt = DateTime.Now;
            realestate.UpdatedAt = DateTime.Now;


            await _context.Realestates.AddAsync(realestate);
            await _context.SaveChangesAsync();

            return realestate;
        }

        public async Task<Realestate> DetailsAsync(Guid id)
        {
            var result = await _context.Realestates
                .FirstOrDefaultAsync(x => x.Id == id);

            return result;
        }

        public async Task<Realestate> Update(RealestateDto dto)
        {
            var domain = new Realestate()
            {
                Id = dto.Id,
                Address = dto.Address,
                SizeSqrM = dto.SizeSqrM,
                RoomCount = dto.RoomCount,
                Floor = dto.Floor,
                BuildingType = dto.BuildingType,
                BuiltInYear = dto.BuiltInYear,
                CreatedAt = dto.CreatedAt,
                UpdatedAt = DateTime.Now,
            };

            _context.Realestates.Update(domain);
            await _context.SaveChangesAsync();

            return domain;
        }

    }
}
