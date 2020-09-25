using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Practical_2._1
{
    class Shop
    {

        ArrayList ProductList = new ArrayList();
        public void addProduct(Product p)
        {
            Console.Write("Name: ");
            p.Name = Console.ReadLine();          
            Console.Write("Price: ");
            p.Price = double.Parse(Console.ReadLine());       
            Console.Write("Description: ");
            p.Description = Console.ReadLine();
            Console.Write("Number of rates: ");
            int N = int.Parse(Console.ReadLine());
            p.Rate = new int[N];
            for (int i = 0; i < N; i++)
            {
                do
                {
                    Console.Write("Rate " + (i + 1) + ": ");
                    p.Rate[i] = int.Parse(Console.ReadLine());
                } while (!(p.Rate[i] >= 1 && p.Rate[i] <= 5));
            }
            ProductList.Add(p);
        }
        public void removeProduct()
        {
            bool search = false;
            Console.Write("Enter the name of the product you want to delete: ");
            String name = Console.ReadLine();
            foreach (Product p in ProductList)
            {
                if (name.Equals(p.Name))
                {
                    search = true;
                    ProductList.Remove(p);
                    break;
                }
            }
            if (search == true)
                Console.WriteLine("Remove Sucessful!");
            else
                Console.WriteLine("Not Found!");
        }
        public void iterateProductList()
        {
            foreach (Product p in ProductList)
            {
                p.viewInfo();
                float averateRate = 0;
                foreach (int rate in p.Rate)
                {
                    averateRate += rate;
                }
                Console.WriteLine("Averate Rate: " + averateRate / p.Rate.Length);
            }
        }
        public void searchProduct()
        {
            double minPrice;
            double maxPrice;
            bool search = false;
            do
            {
                Console.Write("Please enter Min price: ");
                minPrice = double.Parse(Console.ReadLine());
            } while (!(minPrice > 0 && minPrice <= 100));
            do
            {
                Console.Write("Please enter Max price: ");
                maxPrice = double.Parse(Console.ReadLine());
            } while (!(minPrice <= 100 && maxPrice > minPrice));
            foreach (Product p in ProductList)
            {
                if (p.Price >= minPrice && p.Price <= maxPrice)
                {
                    search = true;
                    p.viewInfo();
                }
            }
            if (search == false)
            {
                Console.WriteLine("Not Found!");
            }
        }
    }
}
