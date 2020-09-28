using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Practical_6._1
{
    class PhoneBook : IPhoneBook
    {
        SortedList SortList = new SortedList();
        public int count = 0;
        public void InsertPhone(string Name, string Phone)
        {
           
            Console.WriteLine("Nhap ten : ");
            Name = Console.ReadLine();
            Console.WriteLine("Nhap sdt :");
            Phone = Console.ReadLine();
            SortList.Add(count,(Name,Phone));
            count++;
        }

        public void RemovePhone(string Name)
        {
            Console.WriteLine("Nhap ten sdt can xoa :");
            Name = Console.ReadLine();
            foreach (var item in SortList)
            {
                if (item.Equals(Name))
                {
                    SortList.Remove(Name);
                    break;
                }
            }
        }

        public void SearchPhone(string Name)
        {
            throw new NotImplementedException();
        }

        public void Sort()
        {
            throw new NotImplementedException();
        }

        public void UpdatePhone(string Name, string NewPhone)
        {
            throw new NotImplementedException();
        }
    }
}
