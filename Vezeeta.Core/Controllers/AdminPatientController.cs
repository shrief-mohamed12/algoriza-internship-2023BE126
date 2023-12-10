using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Vezeeta.Core.DTOs.DoctorDTOs;
using Vezeeta.Core.DTOs.PatientDTOs;
using Vezeeta.Domain;
using Vezeeta.Domain.Models;
using Vezeeta.Services.UnitOfWork;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vezeeta.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminPatientController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public AdminPatientController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        [HttpGet("GetAllPatients")]
        public async Task<IActionResult> GetAll()
        {
            var patients = await _unitOfWork.PatientService.GetAllAsync();
            var patientsDTOs = _mapper.Map<List<PatientDTO>>(patients);
            return Ok(patientsDTOs);

        }
        [HttpGet("GetPatientById")]
        public async Task<IActionResult> GetById(string id)
        {
            var patient = await _unitOfWork.PatientService.GetByIdAsync(p=>p.Id == id);
            var patientDTO = _mapper.Map<PatientDTO>(patient);
            return Ok(patientDTO);
        }
    }
}
