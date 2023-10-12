using ShopTARge22.Core.Domain;
using ShopTARge22.Core.Dto;

namespace ShopTARge22.Core.ServiceInterface
{
    public interface IKindergartenServices
    {
        Task<Kindergarten> DetailsAsync(Guid id);
        Task<Kindergarten> Create(KindergartenDto dto);
        Task<Kindergarten> Update(KindergartenDto dto);
        Task<Kindergarten> Delete(Guid id);
    }
}
