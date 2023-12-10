using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
//using Vezeeta.Core.DTOs;
using Vezeeta.Services.UnitOfWork;
using Vezeeta.Domain.Helpers;

namespace Vezeeta.Core.Controllers
{
    //[Authorize(Roles ="Doctor")]
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public DoctorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpPost("LogIn")]
        public async Task<bool> GetTokenAsync([FromBody] LogInModel model)
        {
            if (!ModelState.IsValid)
                return false;

            var result = await _unitOfWork.DocServices.GetTokenLogINAsync(model);
            if (!result.IsAuthenticated)
                return false;
            return true;
        }
    }
}
