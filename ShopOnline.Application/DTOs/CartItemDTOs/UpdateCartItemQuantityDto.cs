﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Application.DTOs.CartItemDTOs
{
    public class UpdateCartItemQuantityDto
    {
        public Guid CartItemId { get; set; }
        public int Quantity { get; set; }
    }
}
