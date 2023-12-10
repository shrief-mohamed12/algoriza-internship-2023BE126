using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Domain.Helpers;
using Vezeeta.Domain.Models;
using Vezeeta.Repository;
using Vezeeta.Services.AdminDoctor;
using Vezeeta.Services.AdminPatient;
using Vezeeta.Services.DoctorServices;
using Vezeeta.Services.PatientSer;

namespace Vezeeta.Services.UnitOfWork
{

    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly Jwt _jwt;
        public IAdminDoctorService DoctorService { get; private set; }

        public IAdminPatientService PatientService { get; private set; }

        public IPatientServices Services {  get; private set; }
        public IDocServices DocServices { get; private set; }

        public UnitOfWork(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IOptions<Jwt> jwt)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _roleManager = roleManager;
            _jwt = jwt.Value;
            DoctorService = new AdminDoctorService(_dbContext);
            PatientService = new AdminPatientService(_dbContext);
            Services = new PatientServices(_dbContext,_userManager, _roleManager, jwt);
            DocServices = new DocServices(_dbContext,_userManager, _roleManager, jwt);
        }
        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
