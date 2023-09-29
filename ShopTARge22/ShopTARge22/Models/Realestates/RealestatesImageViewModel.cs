namespace ShopTARge22.Models.Realestates
{
    public class RealestatesImageViewModel
    {
        public Guid ImageId { get; set; }
        public string ImageTitle { get; set; }
        public byte[] ImageData { get; set; }   
        public string Image { get; set; }
        public Guid RealestateId { get; set; }
    }
}
