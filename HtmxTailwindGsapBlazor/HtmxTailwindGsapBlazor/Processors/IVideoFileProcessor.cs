using LanguageExt.Common;
using Microsoft.AspNetCore.Components.Forms;

namespace HtmxTailwindGsapBlazor.Processors
{
    public interface IVideoFileProcessor
    {
        Result<bool> ConvertToHls(string inputPath, string outputPath);
        Task<Result<bool>> UploadFile(IBrowserFile file, string userId);
    }
}