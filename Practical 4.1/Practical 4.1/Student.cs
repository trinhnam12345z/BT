using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Practical_4._1
{
    class Student : IStudent
    {
        public string FullName { set; get; }
        public int ID { set; get; }
        public DateTime DateofBirth { set; get; }
        public string Native { set; get; }
        public string Class { set; get; }
        public string PhoneNo { set; get; }
        public int Mobile { set; get; }

        public void Display()
        {
            Console.WriteLine("Full name :"+FullName);
            Console.WriteLine("ID : " + ID);
            Console.WriteLine("Dateof Birth :" + DateofBirth);
            Console.WriteLine("Native :" + Native);
            Console.WriteLine("Class :" + Class);
            Console.WriteLine("Phone No : " + PhoneNo);
            Console.WriteLine("Mobile : " + Mobile); 
        }
    }
}
