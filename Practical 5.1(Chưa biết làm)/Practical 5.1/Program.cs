using System;

namespace Practical_5._1
{
    class Program
    {
        public delegate void ReadNewsDelegate(string news);
        static void Main(string[] args)
        {
            ReadNewsDelegate testMethod = new ReadNewsDelegate(TestMethod);

        }
        public static void TestMethod(string news)
        {

        }
    }

}
