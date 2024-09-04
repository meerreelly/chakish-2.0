using Microsoft.AspNetCore.Components.Forms;

namespace chakish_2._0.Classes;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

public class FileUploadService(IWebHostEnvironment environment) : IFileUploadService
{
    public async Task<string> UploadAsync(IBrowserFile file, Guid userId)
    {
        try
        {
            var uploadsFolder = Path.Combine(environment.WebRootPath, $"avatars/{userId.ToString()}");

            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            var filePath = Path.Combine(uploadsFolder, file.Name);

            await using var stream = new FileStream(filePath, FileMode.Create);
            await file.OpenReadStream().CopyToAsync(stream);
            return $"http://localhost:5095/avatars/{userId.ToString()}/{file.Name}";
        }
        catch
        {
            return "";
        }

        
    }
}
