using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Domain;
using Vezeeta.Domain.Models;
using Vezeeta.Repository;

namespace Vezeeta.Services.AdminDoctor
{
    public interface IAdminDoctorService:IRepo<Doctor>
    {
        Task<IEnumerable<Doctor>> GetAllDoctorsWithSpecialize();
        Task<Doctor> GetDoctorWithSpecialize(int id);
        Task<bool> UpdateDoctor(Doctor doctor);
    }
}
