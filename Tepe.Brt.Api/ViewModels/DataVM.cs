namespace Tepe.Brt.Api.ViewModels
{
    public class DataVM
    {
        public string? email { get; set; }
        public string? phone_number { get; set; }
        public string? comment { get; set; }
        public List<RecommendItem> recommendations { get; set; } = new List<RecommendItem>();
        public List<int> missing { get; set; } = new List<int>();
        public List<int> bridge { get; set; } = new List<int>();
        public IFormFile? teeth_image { get; set; }

        public string? Image { get; set; }
    }

    public class RecommendItem
    {
        public string title { get; set; } = string.Empty;

        public string description { get; set; } = string.Empty;

        public string area { get; set; } = string.Empty;
    }
}
