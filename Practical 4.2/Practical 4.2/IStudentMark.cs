using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_4._2
{
    public interface IStudentMark
    {
        public string FullName { set; get; }
        public int ID { set; get; }
        public string Class { set; get; }
        public int Semeter { set; get; }
        public float AverageMark { set; get; }
        public void Display();

    }
}
