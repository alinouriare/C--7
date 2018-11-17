using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecontructSample
{
    class Program
    {
        static void Main(string[] args)
        {


            person p = new person("Ali", "Nouri");
            var (firstName, lastName) = p;
            Console.WriteLine($"Name : {firstName} Family : {lastName}");
            Console.ReadKey();
        }
    }



    class person
    {

        private string FirstName { get; }
        private string LastName { get; }


        public person(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }


        public void Deconstruct(out string firstName,out string lastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }

    }
}
