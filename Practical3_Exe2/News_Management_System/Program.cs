using System;
using System.Collections.Generic;

namespace News_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int choice;
            Console.WriteLine("NEWS MANAGEMENT SYSTEM");
            Console.WriteLine("1. Insert News");
            Console.WriteLine("2. View list News");
            Console.WriteLine("3. Average Rate");
            Console.WriteLine("4. Exit");
            do
            {
                Console.WriteLine("\n Select: ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        program.InsertNews();
                        break;
                    case 2:
                        program.ViewlistNews();
                        break;
                    case 3:
                        program.AverageRate();
                        break;
                    case 4: return;
                }
            }
            while (choice != 4);
        }
        int count = 0;
        Dictionary<int, News> newS = new Dictionary<int, News>();
        public void InsertNews()
        {
            News news = new News();
            news.ID = count;
            Console.WriteLine("Title: ");
            news.Title = Console.ReadLine();
            while (true)
            {

                try
                {
                    Console.WriteLine("Publish Date: ");
                news.PublishDate = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Publish date is not formatted.");
                }
            }
            Console.WriteLine("Author: ");
            news.Author = Console.ReadLine();
            Console.WriteLine("Content: ");
            news.Content = Console.ReadLine();
            for(int i =0; i<3;i++)
            {
                Console.WriteLine("Rate " + (i + 1) + ": ");
                news[i] = int.Parse(Console.ReadLine());
            }
            newS.Add(count, news);
            count++;
        }
        public void ViewlistNews()
        {
                foreach(var item in newS.Values)
                {
                    item.Display();
                }
        }
        public void AverageRate()
        {
            foreach(var item in newS.Values)
            {
                item.Calculate();
                item.Display();
            }
        }
    }
}
