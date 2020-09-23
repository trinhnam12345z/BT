using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Practical_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program t = new Program();

            Cat c = new Cat();
            int choice = 0;
            
            do
            {
                Console.WriteLine("1.Create a Crocodile");
                Console.WriteLine("2.Create a Cat");
                Console.WriteLine("3.Create a Fish");
                Console.WriteLine("4.View Terrestrial Animals");
                Console.WriteLine("5.View Marine Animals");
                Console.WriteLine("6.View All Animals");
                Console.WriteLine("7.Delete Animal");
                Console.WriteLine("8.Exit");
                Console.WriteLine("Please select an item: ");
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        t.AddCrocodile();
                        break;

                    case 2: 
                        t.AddCat();
                        break;
                    case 3:
                        t.AddFish();
                        break;
                    case 4:
                        t.ViewTerrestrialAnimals();
                        break;
                    case 5:
                        t.ViewMarineAnimals();
                        break;
                    case 6:
                        t.ViewAllAnimals();
                        break;
                    case 7:
                        t.DeleteAnimals();
                        break;
                    case 8:
                        return;
                        break;
                }
               
            } while (choice != 8);

        }

        int count = 0;
        Dictionary<int, object> ListAnimal = new Dictionary<int, object>();

        public void AddCat()
        {
            Cat obj = new Cat();
            obj.ID = count;
            Console.Write("Name of cat:");
            obj.Name = Console.ReadLine();
            Console.Write("Age of cat:");
            obj.Age = int.Parse(Console.ReadLine());
            ListAnimal.Add(count, obj);
            count++;
        }
        public void AddFish()
        {
            Fish obj = new Fish();
            obj.ID = count;
            Console.Write("Name of fish:");
            obj.Name = Console.ReadLine();
            Console.Write("Age of fish:");
            obj.Age = int.Parse(Console.ReadLine());
            ListAnimal.Add(count, obj);
            count++;
        }
        public void AddCrocodile()
        {

            Crocodile obj = new Crocodile();
            obj.ID = count;
            Console.Write("Name of crocodile: ");
            obj.Name = Console.ReadLine();
            Console.Write("Age of crocodile: ");
            obj.Age = int.Parse(Console.ReadLine());
            ListAnimal.Add(count, obj);
            count++;
        }
        public void ViewTerrestrialAnimals()
        {
            Cat c = new Cat();
            foreach(var item in ListAnimal)
            {
                if (item.Value.GetType().Equals(c.GetType()))
                {
                   Console.WriteLine(item.ToString());
                    c.Move();
                }
            }
        }
        public void ViewMarineAnimals()
        {

            Fish f = new Fish();
            foreach (var item in ListAnimal)
            {
                if (item.Value.GetType().Equals(f.GetType()))
                {
                    Console.WriteLine(item.ToString());
                    f.Move();
                }
            }
        }
        public void ViewAllAnimals()
        {
            foreach (var item in ListAnimal)
            {
                Console.WriteLine("ID : " + item.Key + " Name : " + item.Value);
            }
        }
        public void DeleteAnimals()
        {
            int n;
            Console.Write("Please select a key: ");
            int.TryParse(Console.ReadLine(), out n);
            foreach (var item in ListAnimal)
            {
                if (item.Key.Equals(n))
                {
                    ListAnimal.Remove(n);
                    break;
                }
            }
            Console.WriteLine(ListAnimal.Count);
        }
    }
}
