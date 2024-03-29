﻿using ShopTARge22.Core.Domain;
using ShopTARge22.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTARge22.Core.ServiceInterface
{
    public interface IRealestatesServices
    {
        Task<RealEstate> Create(RealestateDto dto);
        Task<RealEstate> DetailsAsync(Guid id);
        Task<RealEstate> Update(RealestateDto dto);
        Task<RealEstate> Delete(Guid id);
    }
}
