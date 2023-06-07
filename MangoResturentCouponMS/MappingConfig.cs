using AutoMapper;
using MangoResturentCouponMS.Models.DTO;

namespace MangoResturentCouponMS
{
    public class MappingConfig
    {
        public static MapperConfiguration ResiterMaps()
        {
            var mappingConfiguration = new MapperConfiguration(config =>
            {
                config.CreateMap<Models.Coupon, CouponDTO>().ReverseMap();
            });

            return mappingConfiguration;
        }
    }
}

