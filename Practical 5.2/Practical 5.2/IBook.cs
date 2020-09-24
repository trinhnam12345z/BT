using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Practical_5._2
{
    interface IBook
    {
        public int ID { set; get; }
        public string Name { set; get; } 
        public DateTime PublishDate { set; get; } 
        public string Author { set; get; } 
        public string Language { set; get; } 
        public float AveragePrice { set; get; }

        public void Display();
    }
}
