using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Domain.Models;
using Vezeeta.Repository;

namespace Vezeeta.Services.AdminDoctor
{
    public class DoctorService :Repo<Doctor>,  IDoctorService
    {
        private readonly ApplicationDbContext _dbContext;

        public DoctorService(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> UpdateDoctor(Doctor doctor)
        {
            var existingDoctor = await _dbContext.Doctors.FirstOrDefaultAsync(d=>d.Id== doctor.Id);
            if (existingDoctor != null)
            {
                existingDoctor.Name = doctor.Name;
                existingDoctor.Price = doctor.Price;
                existingDoctor.Description = doctor.Description;
                existingDoctor.ApplicationUserId= doctor.ApplicationUserId;
                existingDoctor.SpecializationId = doctor.SpecializationId;
            }
            return true;
        }
    }
}
