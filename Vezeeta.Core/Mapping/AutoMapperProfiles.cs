using AutoMapper;
using Vezeeta.Core.DTOs.CouponDTOs;
using Vezeeta.Core.DTOs.DoctorDTOs;
using Vezeeta.Core.DTOs.PatientDTOs;
using Vezeeta.Domain;
using Vezeeta.Domain.Models;

namespace Vezeeta.Core.Mapping
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Doctor, DoctorDTO>().ReverseMap();
            CreateMap<AddDoctorRequest, Doctor>().ReverseMap();
            CreateMap<UpdatedDoctorRequest, Doctor>().ReverseMap();
            CreateMap<ApplicationUser,PatientDTO>().ReverseMap();
            CreateMap<AddPatientRequest, ApplicationUser>().ReverseMap();
            CreateMap<UpdatePatientRequest, ApplicationUser>().ReverseMap();
            CreateMap<UpdatePatientRequest, ApplicationUser>().ReverseMap();
            CreateMap<Coupon, UpdateCouponRequest>().ReverseMap();
            CreateMap<Coupon, CreateCouponRequest>().ReverseMap();


        }
    }
}
