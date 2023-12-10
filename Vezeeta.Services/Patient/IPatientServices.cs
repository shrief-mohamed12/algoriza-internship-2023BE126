using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Domain.Helpers;
using Vezeeta.Domain.Models;

namespace Vezeeta.Services.PatientSer
{
    public interface IPatientServices
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
        Task<AuthModel> GetTokenLogINAsync(LogInModel model);
    }
}
