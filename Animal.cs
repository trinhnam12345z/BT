using System;

namespace Tutorial_Source_Code
{
    class Animal
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public int Weight { get; set; }
        public int AnimalID { get; set; }
        
        public Animal(string name = "No Name", double height = 1, int weight = 1)
        {
            Name = name;
            Height = height;
            Weight = weight;
        }

        public override string ToString()
        {
            return string.Format("{0} can nang {1} va chieu cao {2} cm", Name, Weight, Height);
        }
    }

    class Owner
    {
        public string Name { get; set; }
        public int OwnerID { get; set; }
    }
}