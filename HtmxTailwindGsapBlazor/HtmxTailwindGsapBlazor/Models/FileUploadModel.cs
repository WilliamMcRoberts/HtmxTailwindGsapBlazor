using Microsoft.AspNetCore.Components.Forms;

namespace HtmxTailwindGsapBlazor.Models
{
    public class FileUploadModel
    {
        public IReadOnlyList<IBrowserFile> Files { get; set; }
    }
}
