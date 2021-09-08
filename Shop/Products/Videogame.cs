using System;

namespace Shop
{
    public class Videogame : DigitalProduct
    {
        public string Genre { get; set; }
        public int AgeRestricion { get; set; }
        public Videogame(string name, string developer, string publisher, double price, 
                         DateTime realiseDate, int ageRestrict, string genre) : base(name, developer, publisher, price, realiseDate)
        {
            Genre = genre;
            AgeRestricion = ageRestrict;
            Type = ProductType.Videogame;
        }

        public override void GetUserDiscount(User user)
        {
            switch (user.Type)
            {
                case User.UserType.Simple:
                    Price -= Price * 0.1;
                    break;
                case User.UserType.Gold:
                    Price -= Price * 0.2;
                    break;
                case User.UserType.Platinum:
                    Price = Price / 2;
                    break;
            }
        }

    }
}
