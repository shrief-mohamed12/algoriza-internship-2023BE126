using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vezeeta.Core.DTOs.DoctorDTOs;
using Vezeeta.Domain;
using Vezeeta.Domain.Models;
using Vezeeta.Repository;
using Vezeeta.Services.UnitOfWork;

namespace Vezeeta.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminDoctorController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AdminDoctorController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        
        [HttpGet("GetAllDoctors")]
        public async Task<IActionResult> GetAll()
        {
            var doctors = await _unitOfWork.DoctorService.GetAllDoctorsWithSpecialize();
            var doctorsDTOs= _mapper.Map<List<DoctorDTO>>(doctors);
            return Ok(doctorsDTOs);

        }

        
        [HttpGet("GetDoctorById")]
        public async Task<IActionResult> GetById(int id)
        {
            var doctor = await _unitOfWork.DoctorService.GetDoctorWithSpecialize(id);
            var doctorDTO=_mapper.Map<DoctorDTO>(doctor);
            return Ok(doctorDTO);
        }
        [HttpPost("CreateDoctor")]
        public async Task<IActionResult> Create([FromBody] AddDoctorRequest addDoctorRequest)
        {
            var doctor = _mapper.Map<Doctor>(addDoctorRequest);
            var result = await _unitOfWork.DoctorService.AddAsync(doctor);
            await _unitOfWork.SaveAsync();
            return Ok(result);
        }

        
        [HttpPut("UpdateDoctors")]
        public async Task<IActionResult> Update( [FromBody] UpdatedDoctorRequest updatedDoctorRequest)
        {
            var doctor= _mapper.Map<Doctor>(updatedDoctorRequest);
            var result= await _unitOfWork.DoctorService.UpdateDoctor(doctor);
            await _unitOfWork.SaveAsync();
            return Ok(result);
        }

        
        [HttpDelete("DeleteDoctor")]
        public async Task<IActionResult> Delete(int id)
        {
            var doctor = await _unitOfWork.DoctorService.GetByIdAsync(d => d.Id == id);
            var result = _unitOfWork.DoctorService.Delete(doctor);

            await _unitOfWork.SaveAsync();
            return Ok(result);

        }
    }
}
