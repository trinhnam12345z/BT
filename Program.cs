using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Tutorial_Source_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // string[] pxustudents = { "thanh", "thang", "tuan", "ron", "nam", "phuoc", "nam", "nguyen", "quang" };

            // var studentAn = from stu in pxustudents
            //                 where stu.Contains("on")
            //                 orderby stu descending
            //                 select stu;
            // foreach (var i in studentAn)
            // {
            //     Console.WriteLine(i);
            // }

            // int[] nums = { 5, 10, 15, 20, 25, 30, 35 };

            // var getNumber20 = from num in nums
            //                   where num > 20
            //                   orderby num
            //                   select num;

            // foreach (var i in getNumber20)
            // {
            //     Console.WriteLine(i);
            // }


            // ArrayList famAnimals = new ArrayList()
            // {
            //     new Animal{Name = "Cho",Height = .8,Weight = 18},
            //     new Animal{Name = "Meo",Height = 4,Weight = 130},
            //     new Animal{Name = "Su Tu",Height = 3.8,Weight = 90}
            // };

            // var famAnimalEnum = famAnimals.OfType<Animal>();

            // var smAnimals = from animal in famAnimalEnum
            //                 where (animal.Weight <= 90) && (animal.Height > 1)
            //                 orderby animal.Name
            //                 select animal;

            // foreach (var animal in smAnimals)
            // {
            //     Console.WriteLine("{0} can nang {1}",
            //         animal.Name, animal.Weight);

            // }


            Animal[] animals = new[]
            {
                new Animal{Name = "Cho Phu Quoc",
                Height = 25,
                Weight = 77,
                AnimalID = 1},
                new Animal{Name = "Chihuahua",
                Height = 7,
                Weight = 40,
                AnimalID = 2},
                new Animal{Name = "Bull",
                Height = 30,
                Weight = 200,
                AnimalID = 3},
                new Animal{Name = "Pug",
                Height = 12,
                Weight = 16,
                AnimalID = 1},
                new Animal{Name = "Beagle",
                Height = 15,
                Weight = 23,
                AnimalID = 2}
            };

            Owner[] owners = new[]
            {
                new Owner{Name = "Le Tuan",
                OwnerID = 1},
                new Owner{Name = "Nguyen Quang",
                OwnerID = 2},
                new Owner{Name = "Phan Phuoc",
                OwnerID = 3}
            };

            var innerJoin =
               from animal in animals
               join owner in owners on animal.AnimalID
               equals owner.OwnerID
               select new { OwnerName = owner.Name, AnimalName = animal.Name };

            foreach (var i in innerJoin)
            {
                Console.WriteLine("{0} la chu cua {1}",
                    i.OwnerName, i.AnimalName);
            }
        }
    }
}