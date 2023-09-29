namespace ShopTARge22.Core.Dto
{
    public class FileToDatabaseDto
    {
        public Guid Id { get; set; }
        public string ImageTitle { get; set; }
        public byte[] ImageData { get; set; }
        public string ExistingFilePath { get; set; }
        public Guid? RealestateId { get; set; }
    }
}