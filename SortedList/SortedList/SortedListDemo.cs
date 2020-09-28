using System;
using System.Collections;
public class SortedListDemo
{
    public static void Main()
    {
        SortedList mySL = new SortedList();
        mySL.Add(2, "two");
        mySL.Add(1, "one");
        mySL.Add(3, "three");
        //Kiểm tra xem Key có tồn tại trong SortedList hay không.Chạy chương trình và xem kết quả.

        int myKey = 2;
        Console.WriteLine("The key \"{0}\" is {1}.", myKey, mySL.ContainsKey(myKey) ? "in the SortedList" : "NOT in the SortedList");
        myKey = 4;
        Console.WriteLine("The key \"{0}\" is {1}.", myKey, mySL.ContainsKey(myKey) ? "in the SortedList" : "NOT in the SortedList");
        //Kiểm tra xem Value có tồn tại trong SortedList hay không.Chạy chương trình và xem kết quả.

        String myValue = "one";
        Console.WriteLine("The value \"{0}\" is {1}.", myValue, mySL.ContainsValue(myValue) ? "in the SortedList" : "NOT in the SortedList");
        myValue = "nine";
        Console.WriteLine("The value \"{0}\" is {1}.", myValue, mySL.ContainsValue(myValue) ? "in the SortedList" : "NOT in the SortedList");
    }
}