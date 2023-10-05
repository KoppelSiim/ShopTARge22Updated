using ShopTARge22.Core.Dto;
using ShopTARge22.Core.ServiceInterface;

namespace ShopTARge22.Realestate.Test
{
    public class RealestateTest: TestBase
    {
        [Fact]
        public async Task ShouldNot_AddEmptyRealestate_WhenReturnResult()
        {
            RealestateDto realestate = new();
            realestate.Address = "asd";
            realestate.SizeSqrM = 1024;
            realestate.RoomCount = 5;
            realestate.Floor = 3;
            realestate.BuildingType = "asd";
            realestate.BuiltInYear = DateTime.Now;
            realestate.CreatedAt = DateTime.Now;
            realestate.UpdatedAt = DateTime.Now;
            
            var result = await Svc<IRealestateServices>().Create(realestate);
            Assert.NotNull(result);
        }
    }
}
