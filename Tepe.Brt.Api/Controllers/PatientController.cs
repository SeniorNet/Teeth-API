using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Tepe.Brt.Api.ViewModels;
using Tepe.Brt.Business.Services;
using Tepe.Brt.Data.Entities;

namespace Tepe.Brt.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController : ControllerBase
    {

        private readonly IGenericService _genericService;
        private readonly IMapper _mapper;
        private readonly ILogger<PatientController> _logger;

        public PatientController(ILogger<PatientController> logger, IMapper mapper, IGenericService genericService)
        {
            _logger = logger;
            _mapper = mapper;
            _genericService = genericService;
        }

        #region Patient

        // Method to get the list of the patients
        [HttpGet(Name = "GetPatients")]
        public async Task<IResult> GetPatientsList()
        {
            var result = await _genericService.GetPatientList();
            IEnumerable<PatientVM> patients = _mapper.Map<IEnumerable<PatientVM>>(result);
            if (patients == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(patients);
        }

        // Method to get the patient detail by patient ID
        [HttpGet]
        [Route("GetPatientDetailById")]
        public async Task<IResult> GetPatientDetailById(Guid id)
        {
            var result = await _genericService.GetPatientDetailById(id);
            PatientVM patient = _mapper.Map<PatientVM>(result);
            if (patient == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(patient);
        }

        // Method to save the patient detail
        [HttpPost(Name = "SavePatientDetail")]
        public async Task<IResult> SavePatientDetail(PatientVM model)
        {
            PatientEntity patients = _mapper.Map<PatientEntity>(model);
            var result = await _genericService.SavePatientDetail(patients);
            if (result == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(patients);
        }

        // Method to update the patient detail
        [HttpPut(Name = "UpdatePatientDetail")]
        public async Task<IResult> UpdatePatientDetail(PatientVM model)
        {
            PatientEntity patients = _mapper.Map<PatientEntity>(model);
            var result = await _genericService.UpdatePatientDetail(patients);
            if (result == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(patients);
        }

        // Method to delete the patient detail
        [HttpDelete(Name = "DeletePatient")]
        public async Task<IResult> DeletePatient(Guid id)
        {
            await _genericService.DeletePatient(id);
            return Results.Ok();
        }
        #endregion
    }
}
