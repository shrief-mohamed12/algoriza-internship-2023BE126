using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Domain;
using Vezeeta.Domain.Models;
using Vezeeta.Repository;

namespace Vezeeta.Services.AdminPatient
{
    public interface IAdminPatientService:IRepo<ApplicationUser>
    {
        Task<bool> UpdatePatient(string id,ApplicationUser user);
    }
}
