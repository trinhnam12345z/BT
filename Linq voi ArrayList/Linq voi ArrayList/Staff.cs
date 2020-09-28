using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_voi_ArrayList
{
    class Staff
    {
        public int ID { set; get; } 
        public string Name { set; get; } 
        public int Age { set; get; } 
        public Staff(int _ID , string _Name,int _Age)
        {
            ID = _ID;
            Name = _Name;
            Age = _Age;
        }
    }
}
