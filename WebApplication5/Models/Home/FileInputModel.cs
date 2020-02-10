using Microsoft.AspNetCore.Http;

namespace WebApplication5.Models.Home
{
    public class FileInputModel
    {
        public IFormFile FileToUpload { get; set; }
    }
}
