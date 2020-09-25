using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_2._1
{
    class Product
    {

        public String Name { set; get; } 
        public String Description { set; get; } 
        public double Price { set; get; } 
        public int[] Rate { set; get; } 
        public void viewInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Description: " + Description);
        }
    }
}
