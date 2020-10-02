using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Det", 20, 1, 50),
                new Student("Nam", 26, 2, 65),
                new Student("Quang", 20, 3, 80),
                new Student("Hoang", 20, 4, 64),
            };
            string student_file = @"D:\BT\Serialization-main\Serialization-main\pxu4.xml";
            using (Stream fs = new FileStream(student_file, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
                xmlSerializer.Serialize(fs, students);
            }
            List<Student> students1 = null;
            XmlSerializer xmlSerializer1 = new XmlSerializer(typeof(List<Student>));

            using (FileStream fs1 = File.OpenRead(student_file))
            {
                students1 = (List<Student>)xmlSerializer1.Deserialize(fs1);
            }
            foreach (var item in students1)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
