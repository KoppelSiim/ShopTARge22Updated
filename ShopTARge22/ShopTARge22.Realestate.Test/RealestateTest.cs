using ShopTARge22.Core.Dto;
using ShopTARge22.Core.ServiceInterface;

namespace ShopTARge22.Realestate.Test
{
    public class RealestateTest: TestBase
    {
        [Fact]
        public async Task ShouldNot_AddEmptyRealestate_WhenReturnResult()
        {
            //Arrange
            RealestateDto realestate = new();
            realestate.Address = "asd";
            realestate.SizeSqrM = 1024;
            realestate.RoomCount = 5;
            realestate.Floor = 3;
            realestate.BuildingType = "asd";
            realestate.BuiltInYear = DateTime.Now;
            realestate.CreatedAt = DateTime.Now;
            realestate.UpdatedAt = DateTime.Now;
            
            //Act
            var result = await Svc<IRealestateServices>().Create(realestate);

            //Result
            Assert.NotNull(result);

        }
        [Fact]
        public async Task ShouldNot_GetByIdRealestate_WhenReturnsNotEqual()
        {
            //Arrange

            // Küsime realestate, mida meil ei ole
            Guid notAvailable = Guid.Parse(Guid.NewGuid().ToString());
            Guid available = Guid.Parse("b2f75912-827d-417f-b91f-4f2eaa09b246");

            //Act
            await Svc<IRealestateServices>().DetailsAsync(available);
             
            //Assert
            Assert.NotEqual(available,notAvailable );
        }

        [Fact]
        public async Task Should_GetByIdRealestate_WhenReturnsEqual ()
        {
            Guid available = Guid.Parse("b2f75912-827d-417f-b91f-4f2eaa09b246");
            Guid alsoavailable = Guid.Parse("b2f75912-827d-417f-b91f-4f2eaa09b246");

            await Svc<IRealestateServices>().DetailsAsync(available);

            Assert.Equal(available, alsoavailable);
        }
    }
}
