using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_6._1
{
    public interface IPhoneBook
    {
        public void InsertPhone(string Name,string Phone);
        public void RemovePhone(string Name);
        public void UpdatePhone(string Name, string NewPhone);
        public void SearchPhone(string Name);
        public void Sort();
    }
}
