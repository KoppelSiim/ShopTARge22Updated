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

        public async Task<Realestate> Create(RealestatesDto dto)
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
    }
}
