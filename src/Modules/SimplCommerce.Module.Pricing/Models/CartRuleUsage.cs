﻿using System;
using StormyCommerce.Core.Entities;

namespace SimplCommerce.Module.Pricing.Models
{
    public class CartRuleUsage : EntityBase
    {
        public CartRuleUsage()
        {
            CreatedOn = DateTimeOffset.Now;
        }

        public long CartRuleId { get; set; }

        public CartRule CartRule { get; set; }

        public long? CouponId { get; set; }

        public Coupon Coupon { get; set; }

        public long UserId { get; set; }

        public User User { get; set; }

        public long OrderId { get; set; }    
    }
}
