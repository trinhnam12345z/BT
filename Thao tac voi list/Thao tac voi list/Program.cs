using System;
using System.Collections.Generic;
using System.Linq;
namespace Thao_tac_voi_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> MyList = new List<string>();
            MyList.Add("lion");
            MyList.Add("cat");
            MyList.Add("dog");
            MyList.Add("elephant");
            Console.WriteLine("Danh sach hien tai la : ");
            foreach (var item in MyList)
            {
                Console.WriteLine(item); 
            }
            Console.WriteLine("Danh sach sau khi xoa la :");
            MyList.Remove("dog");
            foreach (var item in MyList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Danh sach sau khi sap xep :"); 
            var animal = from name in MyList
                         orderby name.Length
                         select name;
            foreach (var item in animal)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Index cua cat la :"); 
            Console.WriteLine(MyList.IndexOf("cat")); 
        }
    }
}
