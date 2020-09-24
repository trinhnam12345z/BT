using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_4._1
{
    public interface IStudent
    {
        public string FullName { set; get; }
        public int ID { set; get; }
        public DateTime DateofBirth { set; get; }
        public string Native { set; get; }
        public string Class { set; get; }
        public string PhoneNo { set; get; }
        public int Mobile { set; get; }

        public void Display();
    }
}
