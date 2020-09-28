using System;

namespace Ham_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGeneric<int> myGeneric = new MyGeneric<int>();
            myGeneric.SoSanh<int>(2,2);
            myGeneric.SoSanh<string>("nam","nam");

        }
    }
}
