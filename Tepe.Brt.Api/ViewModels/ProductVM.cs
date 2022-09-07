namespace Tepe.Brt.Api.ViewModels
{
    public class ProductVM
    {
        public ProductVM()
        {
            Category = new CategoryVM();
        }

        public Guid Id { get; set; }

        public string? Name { get; set; }

        public string? Size { get; set; }

        public string? Hex { get; set; }

        public Boolean isChecked { get; set; } = false;

        public Guid CategoryID { get; set; }

        public CategoryVM Category { get; set; }
    }
}
