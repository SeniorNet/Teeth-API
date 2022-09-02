using Microsoft.EntityFrameworkCore;
using Tepe.Brt.Data.Entities;

namespace Tepe.Brt.Data.Repositories
{
    public interface IGenericRepository
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

    public class GenericRepository : IGenericRepository
    {
        private readonly ApplicationDbContext _model;
        public GenericRepository(ApplicationDbContext model)
        {
            _model = model;
        }

        #region Patient
        public async Task<IEnumerable<PatientEntity>> GetPatientList()
        {
            var model = await _model.Patients.Include(x=>x.Recommendations).ToListAsync();
            return model;
        }
        public async Task<PatientEntity> GetPatientDetailById(Guid patientId)
        {
            return await _model.Patients.FindAsync(patientId);
        }
        public async Task<PatientEntity> SavePatientDetail(PatientEntity model)
        {
            await _model.Patients.AddAsync(model);
            await _model.SaveChangesAsync();
            return model;
        }
        public async Task<PatientEntity> UpdatePatientDetail(PatientEntity model)
        {
            //_model.Entry(model).State = EntityState.Modified;
            _model.Update(model);
            await _model.SaveChangesAsync();
            return model;
        }
        public async Task DeletePatient(Guid patientId)
        {
            PatientEntity patient = await _model.Patients.FindAsync(patientId);
            if (patient != null)
            {
                _model.Remove(patient);
                await _model.SaveChangesAsync();
            }
        }
        #endregion

        #region Recommendation
        public async Task<IEnumerable<RecommendationEntity>> GetRecommendationList()
        {
            var model = await _model.Recommendations.ToListAsync();
            return model;
        }
        public async Task<RecommendationEntity> GetRecommendationDetailById(Guid patientId)
        {
            return await _model.Recommendations.FindAsync(patientId);
        }
        public async Task<RecommendationEntity> SaveRecommendationDetail(RecommendationEntity model)
        {
            await _model.Recommendations.AddAsync(model);
            await _model.SaveChangesAsync();
            return model;
        }
        public async Task<RecommendationEntity> UpdateRecommendationDetail(RecommendationEntity model)
        {
            //_model.Entry(model).State = EntityState.Modified;
            _model.Update(model);
            await _model.SaveChangesAsync();
            return model;
        }
        public async Task DeleteRecommendation(Guid patientId)
        {
            RecommendationEntity patient = await _model.Recommendations.FindAsync(patientId);
            if (patient != null)
            {
                _model.Remove(patient);
                await _model.SaveChangesAsync();
            }
        }
        #endregion

        #region Product
        public async Task<IEnumerable<ProductEntity>> GetProductList()
        {
            var model = await _model.Products.ToListAsync();
            return model;
        }
        public async Task<ProductEntity> GetProductDetailById(Guid patientId)
        {
            return await _model.Products.FindAsync(patientId);
        }
        public async Task<ProductEntity> SaveProductDetail(ProductEntity model)
        {
            await _model.Products.AddAsync(model);
            await _model.SaveChangesAsync();
            return model;
        }
        public async Task<ProductEntity> UpdateProductDetail(ProductEntity model)
        {
            //_model.Entry(model).State = EntityState.Modified;
            _model.Update(model);
            await _model.SaveChangesAsync();
            return model;
        }
        public async Task DeleteProduct(Guid patientId)
        {
            ProductEntity patient = await _model.Products.FindAsync(patientId);
            if (patient != null)
            {
                _model.Remove(patient);
                await _model.SaveChangesAsync();
            }
        }
        #endregion
    }
}
