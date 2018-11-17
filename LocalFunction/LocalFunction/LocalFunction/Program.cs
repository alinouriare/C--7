using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            MyNumber();

            void MyNumber()
            {
                int myFavNumber = 123;
                Console.WriteLine(myFavNumber);
            }



            int AddTen(int n)
            {
                return n + 10;
            }
            Console.WriteLine(AddTen(20));



            int myValue = 1;
            int Calc(int n) => (n < 2) ? myValue : Calc(n - 1) + Calc(n - 2);
            Console.WriteLine(Calc(8));










            Console.ReadKey();


        }


        public IEnumerable<T> Filter<T>(IEnumerable<T> source,Func<T,bool> filter)
        {

            if (source == null) throw new ArgumentNullException(nameof(source));
            if (filter == null) throw new ArgumentNullException(nameof(filter));
            return Iterator();
            IEnumerable<T> Iterator()
            {

                foreach (var item in source)
                {
                    if (filter(item))
                    {
                        yield return item;
                    }
                }
            }


        }
    }
}
