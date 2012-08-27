﻿using System.Collections.Generic;
using MusicStoreMVC.Models;

namespace MusicStoreMVC.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}