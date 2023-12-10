using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Domain.Models;
using Vezeeta.Repository;

namespace Vezeeta.Services.AdminDoctor
{
    public interface IDoctorService :IRepo<Doctor>
    {
        Task<bool> UpdateDoctor(Doctor doctor);
    }
}
