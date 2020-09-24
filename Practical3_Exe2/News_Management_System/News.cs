using System;
using System.Collections.Generic;
using System.Text;

namespace News_Management_System
{
    class News
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public float AverageRate;
        public float GetAverageRate()
        {
            return AverageRate;
        }
        public virtual void Display()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Publish Date: " + PublishDate);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Content: " + Content);
            Console.WriteLine("Average Rate: " + AverageRate);
        }
        int[] RateList = new int[3];
        public int this[int index]
        {
            get
            {
                return RateList[index];
            }
            set
            {
                RateList[index] = value;
            }
        }
        public void Calculate()
        {
            AverageRate = (float) (RateList[0] + RateList[1] + RateList[2]) / 3;
        }
    }
}
