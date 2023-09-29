namespace ShopTARge22.Models.Realestates
{
    public class RealestatesCreateUpdateViewModel
    {
        public Guid? Id { get; set; }
        public string Address { get; set; }
        public float SizeSqrM { get; set; }
        public int RoomCount { get; set; }
        public int Floor { get; set; }
        public string BuildingType { get; set; }
        public DateTime BuiltInYear { get; set; }
        public List<IFormFile> Files { get; set; }
        public List<RealestatesImageViewModel> Image { get; set; }
        = new List<RealestatesImageViewModel>();
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
