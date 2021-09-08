using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{

    public abstract class DigitalProduct
    {
        public enum ProductType
        {
            Videogame,
            ModelingProgram,
            AudioProgram,
            VideoMontage
        }
        public Guid ProductID { get; set; }
        public ProductType Type { get; set; }
        public string ProductName { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public double Price { get; set; }
        public DateTime RealiseDate { get; set; }

        public DigitalProduct(string name, string developer, string publisher, double price, DateTime realiseDate)
        {
            ProductID = Guid.NewGuid();
            ProductName = name;
            Developer = developer;
            Publisher = publisher;
            Price = price;
            RealiseDate = realiseDate;
        }

        public virtual void GetUserDiscount(User user)
        {
            switch (user.Type)
            {
                case User.UserType.Gold:
                    Price -= Price * 0.2;
                    break;
                case User.UserType.Platinum:
                    Price -= Price * 0.3;
                    break;
            }
        }
    }
}
