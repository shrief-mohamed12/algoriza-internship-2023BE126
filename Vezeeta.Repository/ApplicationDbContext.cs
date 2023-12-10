using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Domain.Models;

namespace Vezeeta.Repository
{
    public  class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
          base(options)
        {

        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorAppointment>  DoctorAppointments { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<BookingPocess>  BookingPocesses { get; set; }
        public DbSet<Specialization> Specializations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
