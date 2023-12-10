using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Domain.Models;
using Vezeeta.Repository;

namespace Vezeeta.Services.AdminCoupon
{
    public class AdminCouponService : Repo<Coupon>, IAdminCouponService
    {
        private readonly ApplicationDbContext _dbContext;

        public AdminCouponService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public bool deactive(Coupon etity)
        {
            throw new NotImplementedException();
        }
    }
    }
