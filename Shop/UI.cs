using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class UI
    {
        public static void DisplayAllProducts(List<DigitalProduct> products)
        {
            int i = 1;
            foreach (DigitalProduct dp in products)
            {
                Console.WriteLine($"{i}. Тип продукта: {dp.Type}, Название: {dp.ProductName}, Цена: {dp.Price}.");
                i++;
            }
            Console.WriteLine("Введите номер товара чтобы добавить его в корзину.");
        }

        public static void DisplayAllVideogames(List<DigitalProduct> products)
        {
            foreach(DigitalProduct p in products)
            {
                var temp = p as Videogame;
                if (temp != null)
                {
                    Console.WriteLine($"Игра: {temp.ProductName}, Жанр: {temp.Genre}");
                }
            }
        }

        public static void DisplayMainMenu(List<DigitalProduct> digitalProducts, User u = null)
        {
            Console.WriteLine($"Здраствуйте, {u?.Name}");
            Console.WriteLine("Выберете действие:");
            Console.WriteLine("1. Показать все товары");
            Console.WriteLine("2. Показать все товары в корзине");
            Console.WriteLine("3. Закрыть программу");

            var str = Console.ReadLine();
            Int32.TryParse(str.ToString(), out var keyInput);
            switch (keyInput)
            {
                case 1:
                    DisplayAllProducts(digitalProducts);
                    break;
                case 2:
                    Console.WriteLine("заглушка");
                    break;
                case 3:
                    Console.WriteLine("Всего доброго!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Введено неверное действие");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
