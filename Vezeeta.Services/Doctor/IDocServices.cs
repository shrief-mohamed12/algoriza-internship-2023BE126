using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Vezeeta.Domain.DTOs;
using Vezeeta.Domain.Helpers;
using Vezeeta.Domain.Models;
using Vezeeta.Repository;

namespace Vezeeta.Services.DoctorServices
{
    public interface IDocServices
    {
        Task<AuthModel> GetTokenLogINAsync(LogInModel model);


    }
}
