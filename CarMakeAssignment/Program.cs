using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace CarMakeAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> products = GetProducts();

            var orderGroups = from p in products
                              group p by p.Maker into g
                              select (Maker: g.Key, Products: g);

            foreach (var orderGroup in orderGroups)
            {
                Console.WriteLine($"Products in {orderGroup.Maker} category:");
                Console.WriteLine($"The number of products in this group is = {orderGroup.Products.Count()}");
                Console.WriteLine("The List of car models is:");
                foreach (var product in orderGroup.Products)
                {
                    Console.WriteLine($"\t{product.Name}");                  
                }
            }
        }
        public static List<Car> GetProducts(){
            List<Car> products = new List<Car>
            {
                new Car() { Name = "Mercedes c-300", Maker = "Benz" },
                new Car() { Name = "GLA SUV", Maker = "Benz" },
                new Car() { Name = "E-Class Wagon", Maker = "Benz" },
                new Car() { Name = "EQS Sedan", Maker = "Benz" },
                new Car() { Name = "S-Class", Maker = "Benz" },
                new Car() { Name = "Toyota 86", Maker = "Lexus" },
                new Car() { Name = "Toyota Corolla", Maker = "Toyota" },
                new Car() { Name = "Toyota Avalon", Maker = "Toyota" },
                new Car() { Name = "Camry", Maker = "Toyota" },
                new Car() { Name = "Highlander", Maker = "Toyota" },
                new Car() { Name = "Lexus RX", Maker = "Lexus" },
                new Car() { Name = "Lexus GX", Maker = "Lexus" },
                new Car() { Name = "Lexus LX", Maker = "Lexus" },
                new Car() { Name = "Lexus LS (XF40)", Maker = "Lexus" },
                new Car() { Name = "Lexus HS 250", Maker = "Lexus" }
            };
            return products;
        }
    }
}
