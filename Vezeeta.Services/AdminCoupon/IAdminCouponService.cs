using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Domain.Models;
using Vezeeta.Repository;

namespace Vezeeta.Services.AdminCoupon
{
    public interface IAdminCouponService :IRepo<Coupon>
    {
        //Task<bool> AddAsync(Coupon entity);
        //bool update(Coupon entity);
        //bool delete(Coupon entity);
        bool deactive(Coupon etity);



    }
}
