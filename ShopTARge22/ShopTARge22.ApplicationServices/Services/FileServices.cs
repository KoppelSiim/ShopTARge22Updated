using Microsoft.Extensions.Hosting;
using ShopTARge22.Core.Domain;
using ShopTARge22.Core.Dto;
using ShopTARge22.Core.ServiceInterface;
using ShopTARge22.Data;
using Microsoft.Extensions.FileProviders;

namespace ShopTARge22.ApplicationServices.Services
{
    public class FileServices : IFileServices
    {
        private readonly IHostEnvironment _webHost;
        private readonly ShopTARge22Context _context;

        public FileServices
            (
                IHostEnvironment webHost,
                ShopTARge22Context context
            )
        {
            _webHost = webHost;
            _context = context;
        }
        public void UploadFilesToDatabase(RealestateDto dto, Realestate domain)
        {
            if( dto.Files!=null && dto.Files.Count > 0)
            {
                foreach (var image in dto.Files)
                {
                    using(var target = new MemoryStream())
                    {
                        FileToDatabase files = new FileToDatabase()
                        {
                            Id = Guid.NewGuid(),
                            ImageTitle = image.Name,
                            RealestateId = domain.Id
                        };
                        image.CopyTo(target);
                        files.ImageData = target.ToArray();

                        _context.FileToDatabases.Add(files);
                    }
                }
            }
        }
        public void FilesToApi(SpaceshipDto dto, Spaceship spaceship)
        {

            if (dto.Files != null && dto.Files.Count > 0)
            {
                if (!Directory.Exists(_webHost.ContentRootPath + "\\multipleFileUpload\\"))
                {
                    Directory.CreateDirectory(_webHost.ContentRootPath + "\\multipleFileUpload\\");
                }

                foreach (var file in dto.Files)
                {
                    string uploadsFolder = Path.Combine(_webHost.ContentRootPath, "multipleFileUpload");
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);

                        FileToApi path = new FileToApi
                        {
                            Id = Guid.NewGuid(),
                            ExistingFilePath = uniqueFileName,
                            SpaceshipId = spaceship.Id,
                        };

                        _context.FileToApis.AddAsync(path);
                        _context.SaveChanges();
                    }
                }
            }
        }
    }
}
