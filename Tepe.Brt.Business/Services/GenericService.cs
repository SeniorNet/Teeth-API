using Tepe.Brt.Data.Entities;
using Tepe.Brt.Data.Repositories;

namespace Tepe.Brt.Business.Services
{
    public interface IGenericService
    {
        #region Patient
        Task<IEnumerable<PatientEntity>> GetPatientList();
        Task<PatientEntity> GetPatientDetailById(Guid patientId);
        Task<PatientEntity> SavePatientDetail(PatientEntity model);
        Task<PatientEntity> UpdatePatientDetail(PatientEntity model);
        Task DeletePatient(Guid id);
        #endregion

        #region Recommendation
        Task<IEnumerable<RecommendationEntity>> GetRecommendationList();
        Task<RecommendationEntity> GetRecommendationDetailById(Guid patientId);
        Task<RecommendationEntity> SaveRecommendationDetail(RecommendationEntity model);
        Task<RecommendationEntity> UpdateRecommendationDetail(RecommendationEntity model);
        Task DeleteRecommendation(Guid id);
        #endregion

        #region Product
        Task<IEnumerable<ProductEntity>> GetProductList();
        Task<ProductEntity> GetProductDetailById(Guid patientId);
        Task<ProductEntity> SaveProductDetail(ProductEntity model);
        Task<ProductEntity> UpdateProductDetail(ProductEntity model);
        Task DeleteProduct(Guid id);
        #endregion
    }
    public class GenericService : IGenericService
    {
        private readonly IGenericRepository _userRepository;
        public GenericService(IGenericRepository userRepository)
        {
            _userRepository = userRepository;
        }

        #region Patient
        public async Task<PatientEntity> GetPatientDetailById(Guid patientId)
        {
            return await _userRepository.GetPatientDetailById(patientId);
        }
        public async Task<IEnumerable<PatientEntity>> GetPatientList()
        {
            return await _userRepository.GetPatientList();
        }
        public async Task<PatientEntity> SavePatientDetail(PatientEntity model)
        {
            return await _userRepository.SavePatientDetail(model);
        }
        public async Task<PatientEntity> UpdatePatientDetail(PatientEntity model)
        {
            return await _userRepository.UpdatePatientDetail(model);
        }
        public async Task DeletePatient(Guid id)
        {
            await _userRepository.DeletePatient(id);
        }
        #endregion

        #region Recommendation
        public async Task<RecommendationEntity> GetRecommendationDetailById(Guid patientId)
        {
            return await _userRepository.GetRecommendationDetailById(patientId);
        }
        public async Task<IEnumerable<RecommendationEntity>> GetRecommendationList()
        {
            return await _userRepository.GetRecommendationList();
        }
        public async Task<RecommendationEntity> SaveRecommendationDetail(RecommendationEntity model)
        {
            return await _userRepository.SaveRecommendationDetail(model);
        }
        public async Task<RecommendationEntity> UpdateRecommendationDetail(RecommendationEntity model)
        {
            return await _userRepository.UpdateRecommendationDetail(model);
        }
        public async Task DeleteRecommendation(Guid id)
        {
            await _userRepository.DeleteRecommendation(id);
        }
        #endregion

        #region Product
        public async Task<ProductEntity> GetProductDetailById(Guid patientId)
        {
            return await _userRepository.GetProductDetailById(patientId);
        }
        public async Task<IEnumerable<ProductEntity>> GetProductList()
        {
            return await _userRepository.GetProductList();
        }
        public async Task<ProductEntity> SaveProductDetail(ProductEntity model)
        {
            return await _userRepository.SaveProductDetail(model);
        }
        public async Task<ProductEntity> UpdateProductDetail(ProductEntity model)
        {
            return await _userRepository.UpdateProductDetail(model);
        }
        public async Task DeleteProduct(Guid id)
        {
            await _userRepository.DeleteProduct(id);
        }
        #endregion
    }
}
