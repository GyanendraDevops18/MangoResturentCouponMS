﻿using MangoResturentCouponMS.Models.DTO;
using MangoResturentCouponMS.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MangoResturentCouponMS.Controllers
{
    [ApiController]
    [Route("api/coupon")]
    public class CouponAPIController : ControllerBase
    {
        private readonly ICouponRepository _couponRepository;
        protected ResponseDTO _response;

        public CouponAPIController(ICouponRepository couponRepository)
        {
            _couponRepository = couponRepository;
            this._response = new ResponseDTO();
        }

        [HttpGet("{code}")]
        public async Task<object> GetDiscountForCode(string code)
        {
            try
            {
                var coupon = await _couponRepository.GetCouponByCode(code);
                _response.Result = coupon;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }
    }
}
