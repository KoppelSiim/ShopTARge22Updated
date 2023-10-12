using Microsoft.EntityFrameworkCore;
using ShopTARge22.Core.Domain;
using ShopTARge22.Core.ServiceInterface;
using ShopTARge22.Data;

namespace ShopTARge22.ApplicationServices.Services
{
    public class KirdergartenServices: IKindergartenServices
    {
        private readonly ShopTARge22Context _context;

        public KirdergartenServices(ShopTARge22Context context)
        {
            _context = context;
        }
        public async Task<Kindergarten> DetailsAsync(Guid id)
        {
            var result = await _context.Kindergartens
                .FirstOrDefaultAsync(x => x.Id == id);

            return result;
        }
    }
}
