using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Services.AdminDoctor;
using Vezeeta.Services.AdminPatient;
using Vezeeta.Services.DoctorServices;
using Vezeeta.Services.PatientSer;

namespace Vezeeta.Services.UnitOfWork
{
    public interface IUnitOfWork
    {
        IAdminDoctorService DoctorService { get; }
        IAdminPatientService PatientService { get; }
        IPatientServices Services { get; }
        IDocServices DocServices { get; }
        Task SaveAsync();
    }
}

