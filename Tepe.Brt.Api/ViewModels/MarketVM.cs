namespace Tepe.Brt.Api.ViewModels
{
    public class MarketVM
    {
        public MarketVM()
        {
            Categories = new List<CategoryVM>();
        }

        public Guid Id { get; set; }

        public string? Country { get; set; }

        public string? LangCode { get; set; }

        public virtual IEnumerable<CategoryVM> Categories { get; set; }
    }
}
