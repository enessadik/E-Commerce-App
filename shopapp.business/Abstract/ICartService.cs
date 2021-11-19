using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.business.Abstract
{
    public interface ICartService
    {
        void InitializeCart(string userId);
        Cart GetCartByUserId(string userId);
        void AddtoCart(string userId, int productId, int quantity);
        void DeleteFromCart(string userId, int productId);

    }
}
