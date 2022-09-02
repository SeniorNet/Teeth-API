using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Tepe.Brt.Api.ViewModels;
using Tepe.Brt.Business.Services;
using Tepe.Brt.Data.Entities;

namespace Tepe.Brt.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly IGenericService _genericService;
        private readonly IMapper _mapper;
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger, IMapper mapper, IGenericService genericService)
        {
            _logger = logger;
            _mapper = mapper;
            _genericService = genericService;
        }

        #region Product

        // Method to get the list of the products
        [HttpGet(Name = "GetProducts")]
        public async Task<IResult> GetProductsList()
        {
            var result = await _genericService.GetProductList();
            IEnumerable<ProductVM> patients = _mapper.Map<IEnumerable<ProductVM>>(result);
            if (patients == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(patients);
        }

        // Method to get the product detail by product ID
        [HttpGet]
        [Route("GetProductDetailById")]
        public async Task<IResult> GetProductDetailById(Guid id)
        {
            var result = await _genericService.GetProductDetailById(id);
            ProductVM patient = _mapper.Map<ProductVM>(result);
            if (patient == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(patient);
        }

        // Method to save the product detail
        [HttpPost(Name = "SaveProductDetail")]
        public async Task<IResult> SaveProductDetail(ProductVM model)
        {
            ProductEntity patients = _mapper.Map<ProductEntity>(model);
            var result = await _genericService.SaveProductDetail(patients);
            if (result == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(patients);
        }

        // Method to update the product detail
        [HttpPut(Name = "UpdateProductDetail")]
        public async Task<IResult> UpdateProductDetail(ProductVM model)
        {
            ProductEntity patients = _mapper.Map<ProductEntity>(model);
            var result = await _genericService.UpdateProductDetail(patients);
            if (result == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(patients);
        }

        // Method to delete the product detail
        [HttpDelete(Name = "DeleteProduct")]
        public async Task<IResult> DeleteProduct(Guid id)
        {
            await _genericService.DeleteProduct(id);
            return Results.Ok();
        }
        #endregion
    }
}
