﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsExpressionsSample
{
    class Program
    {
        static void Main(string[] args)
        {

            PersonCar pc = new PersonCar("Ali", "Nouri", 30, "206", 1397);
            //اگر pc زیر مجموعه person هست
            if (pc is Person p)
            {
                Console.WriteLine($"Name : {p.Name} - Family:{p.Family} - Age:{p.Age}");

            }

            Console.ReadKey();
        }


        class Person
        {


            public string Name { get; set; }

            public string    Family { get; set; }

            public int Age { get; set; }
        }



        class PersonCar:Person
        {

            public string CarName { get; set; }
            public int CarModel { get; set; }


            public PersonCar(string name, string family, int age, string carName, int carModel)
            {

                Name = name;
                Family = family;
                Age = age;
                CarName = carName;
                CarModel = carModel;
            }
        }
    }
}
