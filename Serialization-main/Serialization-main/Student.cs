using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Serialization
{
    [Serializable()]
    public class Student :ISerializable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        public double Weight { get; set; }

        public Student() { }
        public Student(string name, int age, int id, double weight)
        {
            Name = name;
            Age = age;
            Id = id;
            Weight = weight;
        }
        //Đọc file
        public Student(SerializationInfo info, StreamingContext context)
        {
            Id = (int)info.GetValue("Id", typeof(int));
            Name = (string)info.GetValue("Id", typeof(string));
            Age = (int)info.GetValue("Id", typeof(int));
            Weight = (double)info.GetValue("Id", typeof(double));
        }
        //
        public override string ToString()
        {
            return string.Format($"Sinh vien {Name} co Id {Id} nam nay {Age} tuoi");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("Name", Name);
            info.AddValue("Age", Age);
            info.AddValue("Weight", Weight);
        }
    }
}
