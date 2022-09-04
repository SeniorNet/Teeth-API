using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tepe.Brt.Api.ViewModels
{
    public class RecommendationVM
    {
        public Guid Id { get; set; }

        public string? Comment { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        public string? Image { get; set; }

        public string? Bridge { get; set; }

        public string? Missing { get; set; }

        [NotMapped]
        public List<int> BridgeArray { get; set; }

        [NotMapped]
        public List<int> MissingArray { get; set; }

        public Guid PatientID { get; set; }

        //public PatientVM Patient { get; set; }
    }
}
