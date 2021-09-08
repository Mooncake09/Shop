using System;
using System.Collections.Generic;

namespace Shop
{
    class Program
    {
        //public delegate void DisplayDelegate(List<DigitalProduct>, string);
        static void Main(string[] args)
        {
            var simpleUser = new User("Михаил", User.UserType.Simple);
            var goldUser = new User("Анатолий", User.UserType.Gold);
            var platinumUser = new User("Виктор", User.UserType.Platinum);

            var allProducts = new List<DigitalProduct>();
            allProducts.AddRange(new DigitalProduct[] { new Videogame("serious sam", "croteam", "devolver digital", 800.0, new DateTime(2011, 11, 09), 18, "shooter"),
                                                        new Videogame("Call of Duty", "Treyarch", "Activision", 2000.0, new DateTime(2001, 10, 09), 18, "shooter"),
                                                        new Videogame("Dragon age: Origins", "Bioware", "Electronic Arts", 2000.0, new DateTime(2009, 09, 10), 18, "RPG"),
                                                        new ModelingProgram("Blender", "Blender inc", "Blender inc", 0.0, new DateTime(1999, 12, 05))});
            var cart = new Cart();

            while (true) 
            {
                UI.DisplayMainMenu(allProducts, simpleUser);
                var str = Console.ReadLine();
                var productNumber = Convert.ToInt32(str) - 1;
                if (productNumber < allProducts.Count  && productNumber > 0)
                {
                    cart.Products.Add(allProducts[productNumber]);
                    Console.WriteLine($"Товар {allProducts[productNumber].ProductName} успешно добавлен в корзину!");
                }
                Console.WriteLine("Введите 'Y' если хотите продолжить покупки");
                Console.WriteLine("Или введите 'N', если хотите перейти к оплате");
            }
        }
    }
}
