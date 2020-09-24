using System;
using System.Collections.Generic;

namespace Practical_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program t = new Program();
            int choice = 0;

            do
            {
                Console.WriteLine("1.Insert new book");
                Console.WriteLine("2.View list of books ");
                Console.WriteLine("3.Average Price ");
                Console.WriteLine("4.Exit ");
                Console.WriteLine("Please select an item: ");
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        t.InsertBooks();
                        break;

                    case 2:
                        t.ViewListBooks();
                        break;
                    case 3:
                        t.AveragePrice();
                        break;
                    case 4:
                        return;
                        break;
                }

            } while (choice != 5);
        }
        int count = 0;
        Dictionary<int, object> ListBook = new Dictionary<int, object>();
        public void InsertBooks()
        {
            Book book = new Book();
            book.ID = count;
            Console.WriteLine("Input Name : ");
            book.Name = Console.ReadLine();
            Console.WriteLine("Input Publish Date :");
            book.PublishDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Input Author :");
            book.Author = Console.ReadLine();
            Console.WriteLine("Input language :");
            book.Language = Console.ReadLine();            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Input Average Price " + (i + 1) + ":");
                book[i] = int.Parse(Console.ReadLine());

            }
            ListBook.Add(count, book);
            count++;

        }
        public void ViewListBooks()
        {
            foreach (Book item in ListBook.Values)
            {
                item.Display();
            }
        }
        public void AveragePrice()
        {
            foreach (Book item in ListBook.Values)
            {
                item.Display();
                item.Calculate();
            }
        }
    }
}
