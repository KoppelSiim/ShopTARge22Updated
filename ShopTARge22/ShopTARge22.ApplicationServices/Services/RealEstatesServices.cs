using ShopTARge22.Core.ServiceInterface;
using ShopTARge22.Data;

namespace ShopTARge22.ApplicationServices.Services
{
    public class RealestatesServices : IRealestates

    {
        private readonly ShopTARge22Context _context;

        public RealestatesServices(ShopTARge22Context context)
        {
            _context = context;
        }
    }
}
