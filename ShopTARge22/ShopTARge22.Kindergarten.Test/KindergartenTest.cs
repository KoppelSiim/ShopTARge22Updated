using ShopTARge22.Core.Domain;
using ShopTARge22.Core.Dto;
using ShopTARge22.Core.ServiceInterface;
/* KG Dto
   public Guid? Id { get; set; }
   public string GroupName { get; set; }
   public int ChildrenCount { get; set; }
   public string KindergartenName { get; set; }
   public string Teacher { get; set; }
   public DateTime CreatedAt { get; set; }
   public DateTime UpdatedAt { get; set; }
 */
namespace ShopTARge22.Kindergarten.Test
{
    public class KindergartenTest: TestBase
    {
        [Fact]
        public async Task ShouldNot_AddEmptyKindergarten_WhenReturnResult()
        {
            //Arrange - create the Dto object and assign values
            KindergartenDto kindergarten = new();
            kindergarten.GroupName = "MingiGruppOn";
            kindergarten.ChildrenCount = 343;
            kindergarten.KindergartenName = "Leevike";
            kindergarten.Teacher = "Linda Hinda";
            kindergarten.CreatedAt = DateTime.Now;
            kindergarten.UpdatedAt = DateTime.Now;

            //Act
            var result = await Svc<IKindergartenServices>().Create(kindergarten);
            //Result
            Assert.NotNull(result);
        }
    }
}