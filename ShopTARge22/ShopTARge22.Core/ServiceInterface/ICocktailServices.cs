using ShopTARge22.Core.Dto.CoctailsDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTARge22.Core.ServiceInterface
{
    public interface ICocktailServices
    {
        Task<CoctailResultDto> GetCocktails(CoctailResultDto dto);
    }
}
