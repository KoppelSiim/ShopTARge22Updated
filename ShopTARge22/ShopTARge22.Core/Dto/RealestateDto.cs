﻿using Microsoft.AspNetCore.Http;

namespace ShopTARge22.Core.Dto
{
    public class RealestateDto
    {
        public Guid? Id { get; set; }
        public string Address { get; set; }
        public float SizeSqrM { get; set; }
        public int RoomCount { get; set; }
        public int Floor { get; set; }
        public string BuildingType { get; set; }
        public DateTime BuiltInYear { get; set; }
        public List<IFormFile> Files  {get;set;}
        public IEnumerable<FileToDatabaseDto> FileToApiDtos { get; set; }
            = new List<FileToDatabaseDto>();
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public FileToDatabaseDto[] Image { get; set; }
    }
}
