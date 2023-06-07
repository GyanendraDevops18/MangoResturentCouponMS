using AutoMapper;
using MangoResturentCouponMS.DBContext;
using MangoResturentCouponMS.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace MangoResturentCouponMS.Repository
{
    public class CouponRepository : ICouponRepository
    {
        private readonly ApplicationDbContext db;
        protected IMapper _mapper;
        public CouponRepository(ApplicationDbContext _db, IMapper mapper)
        {
            db = _db;
            _mapper = mapper;
        }

        public async Task<CouponDTO> GetCouponByCode(string couponCode)
        {
            var couponFromDb = await db.Coupons.FirstOrDefaultAsync(u => u.CouponCode == couponCode);
            return _mapper.Map<CouponDTO>(couponFromDb);
        }
    }
}
