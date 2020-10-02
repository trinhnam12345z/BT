using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Thi_cuoi_mon
{
    class Forum
    {
        static void Main(string[] args)
        {
            Forum t = new Forum();
            int choice = 0;

            do
            {
                Console.WriteLine("1.Create Post ");
                Console.WriteLine("2.Update Post ");
                Console.WriteLine("3.Remove Post ");
                Console.WriteLine("4.Show Post ");
                Console.WriteLine("5.Exit"); 
                Console.WriteLine("Please select an item: ");
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        t.CreatePost();
                        break;

                    case 2:
                        t.UpdatePost();
                        break;
                    case 3:
                        t.RemovePost();
                        break;
                    case 4:
                        t.ShowPost();
                        break;
                    case 5:
                        return;
                }

            } while (choice != 6);
        }
        int count = 0;
        SortedList MySL = new SortedList();

        public void CreatePost()
        {
            Post post = new Post();
            post.ID = count;
            Console.WriteLine("Input Title :");
            post.Title = Console.ReadLine();
            Console.WriteLine("Input Content :");
            post.Content = Console.ReadLine();
            Console.WriteLine("Input Anuthor :");
            post.Author = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Input Rate :");
                post.Rates[i] = int.Parse(Console.ReadLine());
            }
            post.CalculatorRate();
            MySL.Add(count, post);
            count++;
        }
        public void UpdatePost()
        {
            bool search = false;
            Console.Write("Enter the ID of the Post you want to update : ");
            int id = int.Parse(Console.ReadLine());
            foreach (Post item in MySL.Values)
            {
                if (id.Equals(item.ID))
                {
                    search = true;
                    MySL.Remove(id);
                    
                    break;
                }
            }
            if (search == true)
                Console.WriteLine("Remove Sucessful!");
            else
                Console.WriteLine("Not Found!");
        }
        public void RemovePost()
        {
            bool search = false;
            Console.Write("Enter the ID of the Post you want to delete : ");
            int id = int.Parse(Console.ReadLine());
            foreach (Post item in MySL.Values)
            {
                if (id.Equals(item.ID))
                {
                    search = true;
                    MySL.Remove(id);
                    break;
                }
            }
            if (search == true)
                Console.WriteLine("Remove Sucessful!");
            else
                Console.WriteLine("Not Found!");
        }
        public void ShowPost()
        {
            foreach (Post item in MySL.Values)
            {
                item.Display();
            }
        }


    }     
}
