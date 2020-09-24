using System;
using System.Collections.Generic;

namespace Practical_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program t = new Program();            
            int choice = 0;

            do
            {
                Console.WriteLine("1.Add student");
                Console.WriteLine("2.View all student ");
                Console.WriteLine("3.Search Student ");
                Console.WriteLine("4.Exit ");                
                Console.WriteLine("Please select an item: ");
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:
                        t.AddStudent();
                        break;

                    case 2:
                        t.ViewAllStudent();
                        break;
                    case 3:
                        t.SearchStudent();
                        break;                                       
                    case 4:
                        return;
                        break;
                }

            } while (choice != 5);
        }
        int count = 0;
        Dictionary<int, object> ListStudent = new Dictionary<int, object>();
        public void AddStudent()
        {
            Student student = new Student();
            student.ID = count;
            Console.WriteLine("Nhap full name :");
            student.FullName = Console.ReadLine();
            Console.WriteLine("Nhap Dateof Birth :");
            student.DateofBirth = DateTime.Parse(Console.ReadLine());  ;
            Console.WriteLine("Nhap Native :");
            student.Native = Console.ReadLine();
            Console.WriteLine("Nhap Class : ");
            student.Class = Console.ReadLine();
            Console.WriteLine("Nhap Phone No : ");
            student.PhoneNo = Console.ReadLine();
            Console.WriteLine("Nhap Mobile : ");
            student.Mobile = int.Parse(Console.ReadLine());
            ListStudent.Add(count, student);
            count++;
        }
        public void ViewAllStudent()
        {
            foreach (Student item in ListStudent.Values)
            {
                item.Display();
            }
        }
        public void SearchStudent()
        {
            Console.WriteLine("Nhap ten hoc sinh: ");
            string name = Console.ReadLine();
            foreach (Student item in ListStudent.Values)
                if (item.FullName.Equals(name))
                    item.Display();
                else Console.WriteLine("Loi khong tim thay ten");
        }
    }
}
