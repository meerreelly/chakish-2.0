using Microsoft.AspNetCore.Components.Forms;

namespace chakish_2._0.Classes;

public interface IFileUploadService
{
    Task<string> UploadAsync(IBrowserFile file, Guid userId);
}