using ShopTARge22.Core.Domain;
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
            Guid databaseGuid = Guid.Parse("b2f75912-827d-417f-b91f-4f2eaa09b246");
            Guid guid = Guid.Parse("b2f75912-827d-417f-b91f-4f2eaa09b246");

            await Svc<IRealestateServices>().DetailsAsync(databaseGuid);

            Assert.Equal(databaseGuid, guid);
        }

        [Fact] public async Task Should_DeleteByIdRealestate_WhenDeleteRealestate()
        {
            RealestateDto realestate = MockRealestateData();
            var addRealestate = await Svc<IRealestateServices>().Create(realestate);
            var result = await Svc<IRealestateServices>().Delete((Guid)addRealestate.Id);
            Assert.Equal(addRealestate,result);   
        }

        [Fact] public async Task ShouldNot_DeleteByIdRealestate_WhenDidNotDeleteRealestate()
        {
            RealestateDto realestate = MockRealestateData();
            var addRealestate1 = await Svc<IRealestateServices>().Create(realestate);
            var addRealestate2 = await Svc<IRealestateServices>().Create(realestate);

            var result = await Svc<IRealestateServices>().Delete((Guid)addRealestate2.Id);
            Assert.NotEqual(addRealestate1.Id,result.Id);
        }

        [Fact] public async Task Should_UpdateRealestate_WhenUpdateData()
        {
            // vaja saada guid
            var guid = new Guid("b2f75912-827d-417f-b91f-4f2eaa09b246");

            RealestateDto dto = MockRealestateData();
            // vaja saada domainist andmed
            RealEstate realestate = new();
            realestate.Id = Guid.Parse("b2f75912-827d-417f-b91f-4f2eaa09b246");
            realestate.Address = "asd132";
            realestate.SizeSqrM = 123;
            realestate.RoomCount = 13;
            realestate.Floor = 3;
            realestate.BuildingType= "ASDASD";
            realestate.BuiltInYear = DateTime.Now.AddYears(1);
            await Svc<IRealestateServices>().Update(dto);

            Assert.Equal(realestate.Id, guid);
            Assert.DoesNotMatch(realestate.Address, dto.Address);
            Assert.DoesNotMatch(realestate.Floor.ToString(), dto.Floor.ToString());
            Assert.Equal(realestate.RoomCount, dto.RoomCount);
           
            
           
          
            // kasutan domaini andmeid

        }


        private RealestateDto MockRealestateData()
        {
            RealestateDto realestate = new()
            {
                Address = "asd",
                SizeSqrM = 123,
                RoomCount = 13,
                Floor = 99,
                BuildingType = "asd",
                BuiltInYear = DateTime.Now,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            return realestate;
        }
    }
}
