using Microsoft.AspNetCore.Mvc;
using Vezeeta.Domain.Helpers;

//using Vezeeta.Domain.DTOs;
using Vezeeta.Services.PatientSer;
using Vezeeta.Services.UnitOfWork;
//using Vezeeta.Services.UnitOfWork;

namespace Vezeeta.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : Controller
    {
           private readonly IUnitOfWork _unitOfWork;
        //private readonly IPatientServices _patientServices;

        public PatientController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _unitOfWork.Services.RegisterAsync(model);

            if (!result.IsAuthenticated)
                return BadRequest(result.Message);
            return Ok(result);
        }
        [HttpPost("LogIn")]
        public async Task<bool> GetTokenAsync([FromBody] LogInModel model)
        {
            if (!ModelState.IsValid)
                return false;

            var result = await _unitOfWork.Services.GetTokenLogINAsync(model);

            if (!result.IsAuthenticated)
                return false;
            return true;
        }
    }
}
