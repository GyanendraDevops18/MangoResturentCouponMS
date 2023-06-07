using MangoResturentCouponMS.Models.DTO;

namespace MangoResturentCouponMS.Repository
{
    public interface ICouponRepository
    {
        Task<CouponDTO> GetCouponByCode(string couponCode);
    }
}
