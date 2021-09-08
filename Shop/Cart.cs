using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    public sealed class Cart
    {
        public double TotalPrice { get; set; }
        public List<DigitalProduct> Products { get; set; }
        public void Buy(User user)
        {
            TotalPrice = 0;
            foreach (DigitalProduct product in Products)
            {
                product.GetUserDiscount(user);
                TotalPrice += product.Price;
            }
            if (user.CheckUserSolvency(TotalPrice))
            {
                Console.WriteLine($"Пользователь {user.Name} купил {Products.Count} товара по цене {TotalPrice}.");
                user.ReduceBalance(TotalPrice);
            }
            else
            {
                Console.WriteLine("Покупка не была совершена. Причина: недостатчно средств.");
            }
        }
    }
}
