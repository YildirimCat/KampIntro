using Methods;
using System;
using System.Collections.Generic;
using System.Linq;


namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Explanation = "Amasya elması";
            
            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Explanation = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };
            
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("--------------");
            }
            Console.WriteLine("----------Metotlar-----------");
            
            ChartManager chartManager = new ChartManager();
            chartManager.Add(product1);
            chartManager.Add(product2);

            chartManager.Add2("Armut", "Yeşil armut", 5);
            chartManager.Add2("Kavun", "Güzel Kavun", 10);
            chartManager.Add2("Soğan", "Bursa soğanı", 20);

        }
    }
}
