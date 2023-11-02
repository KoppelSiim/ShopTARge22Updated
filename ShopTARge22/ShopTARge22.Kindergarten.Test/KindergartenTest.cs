using ShopTARge22.Core.Domain;
using ShopTARge22.Core.Dto;
using ShopTARge22.Core.ServiceInterface;

namespace ShopTARge22.Kindergarten.Test
{
    public class KindergartenTest: TestBase
    {
        [Fact]
        public async Task ShouldNot_AddEmptyKindergarten_WhenReturnResult()
        {
            //Arrange
            KindergartenDto kindergarten = new();
        }
    }
}