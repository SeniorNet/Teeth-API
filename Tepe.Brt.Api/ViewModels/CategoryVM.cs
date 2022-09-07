using System.ComponentModel.DataAnnotations.Schema;

namespace Tepe.Brt.Api.ViewModels
{
    public class CategoryVM
    {
        public CategoryVM()
        {
            Markets = new List<MarketVM>();

            Products = new List<ProductVM>();
        }

        public Guid Id { get; set; }

        public string? Title { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        public string? catImeage { get; set; }

        public virtual IEnumerable<MarketVM> Markets { get; set; }

        public virtual IEnumerable<ProductVM> Products { get; set; }
    }
}
