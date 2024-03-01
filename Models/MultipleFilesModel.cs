using System.ComponentModel.DataAnnotations;

namespace UploadFile.Models
{
    public class MultipleFilesModel : ReponseModel
    {
        [Required(ErrorMessage = "Please select files")]
        public List<IFormFile> Files { get; set; }
    }
}
