using Microsoft.EntityFrameworkCore;
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
    public class AdminDoctorService : Repo<Doctor>, IAdminDoctorService
    {
        private readonly ApplicationDbContext _dbContext;

        public AdminDoctorService(ApplicationDbContext dbContext) : base(dbContext)
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
        public async Task<IEnumerable<Doctor>> GetAllDoctorsWithSpecialize()
        {
            var doctors = await _dbContext.Doctors.Include(d => d.Specialization).ToListAsync();
            return doctors;
        }
        public async Task<Doctor> GetDoctorWithSpecialize(int id)
        {
            var doctor = await _dbContext.Doctors.Include(d => d.Specialization).FirstOrDefaultAsync(d => d.Id == id);
            return doctor;
        }
    }
}
