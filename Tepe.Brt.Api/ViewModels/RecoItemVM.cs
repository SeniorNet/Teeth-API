using Tepe.Brt.Data.Entities;

namespace Tepe.Brt.Api.ViewModels
{
    public class RecoItemVM
    {
        //public ProductVM()
        //{
        //    Recommendation = new RecommendationEntity();
        //}
        public Guid Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? Area { get; set; }

        public Guid RecommendationID { get; set; }

        public RecommendationEntity? Recommendation { get; set; }
    }
}
