using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Domain;
using Vezeeta.Domain.Models;
using Vezeeta.Repository;

namespace Vezeeta.Services.AdminPatient
{
    public class AdminPatientService : Repo<ApplicationUser>, IAdminPatientService
    {
        private readonly ApplicationDbContext _dbContext;
        public AdminPatientService(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext= dbContext;
        }

        public async Task<bool> UpdatePatient(string id, ApplicationUser user)
        {
            var existingPatient = await _dbContext.ApplicationUsers.FirstOrDefaultAsync(d => d.Id == id);
            if (existingPatient != null)
            {
                
               // existingPatient.Name = user.Name;
                existingPatient.Email = user.Email;
                //existingPatient. = user.City;
                existingPatient.PhoneNumberConfirmed = user.PhoneNumberConfirmed;
                existingPatient.UserName = user.UserName;
                existingPatient.AccessFailedCount = user.AccessFailedCount;
                existingPatient.EmailConfirmed = user.EmailConfirmed;
                existingPatient.LockoutEnabled = user.LockoutEnabled;
            }
            return true;
        }
    }
}
