using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Exam5();
            Console.ReadKey();

        }


  


        //String.format ===$
        //static void Exam1()
        //{
        //    var person = new Tuple<string, string, int>("Ali", "Nouri", 30);
        //    Console.WriteLine($"name:{person.Item1}:Family:{person.Item2}Age:{person.Item3}");
        //}

        //static void Exam2()
        //{
        //    var site = Tuple.Create("AlinNuri.Com", "AliNouriAre.Com", "Ali nouri", "09359504672", "1");

            
        //    Console.WriteLine($"{site.Item1} - {site.Item2} - {site.Item3} - {site.Item4} - {site.Item5}");
        //}


        //static void Exam3()
        //{

        //    var nestedTuple = new Tuple<int, int, int, int, int, int, int,

        //        Tuple<string, string>>(1, 2, 3, 4, 5, 6, 7, Tuple.Create("Ali", "Nouri"));
        //    Console.WriteLine($"{ nestedTuple.Item1}-{nestedTuple.Rest.Item1}");
        //}



        static void Exam4()
        {

            TupleSample tu = new TupleSample();
            var person= Tuple.Create("Ali", "Nouri", 30);
            tu.SetTupleInMethod(person);
        }

        static void Exam5()
        {

            var person = TupleSample.GetTuple();
            Console.WriteLine($"Name : {person.Item1} Family : {person.Item2} Age: {person.Item3}");
        }
        
    }


    public class TupleSample
    {


        public void SetTupleInMethod(Tuple<string,string,int> person)
        {

            Console.WriteLine($"Name:{person.Item1}- Family:{person.Item2}- Age:{person.Item3}");
        }

        public static Tuple<string,string,int> GetTuple()
        {

            return Tuple.Create("Ali", "Nouri", 30);
        }
    }
}
