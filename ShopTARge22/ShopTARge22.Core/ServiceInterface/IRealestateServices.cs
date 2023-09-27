using ShopTARge22.Core.Domain;
using ShopTARge22.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTARge22.Core.ServiceInterface
{
    public interface IRealestateServices
    {
        Task<Realestate> Create(RealestatesDto dto);
        Task<Realestate> DetailsAsync(Guid id);
    }
}
