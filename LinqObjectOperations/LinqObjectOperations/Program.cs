using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqObjectOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("select :");
            Console.WriteLine(string.Join(" ", numbers.Select(n => Math.Pow(n, 2))));
            Console.WriteLine("\nselect Many :");
            Console.WriteLine(string.Join(" ", numbers.SelectMany(n => GetValues(n))));
            Console.WriteLine("\nSkip:");
            Console.WriteLine(string.Join(" ", numbers.Skip(2)));
            Console.WriteLine("\nSkipWhile:");
            Console.WriteLine(string.Join(" ", numbers.SkipWhile(n => n < 2)));
            Console.WriteLine("\nTake:");
            Console.WriteLine(string.Join(" ", numbers.Take(4)));
            Console.WriteLine("\nTakeWhile:");
            Console.WriteLine(string.Join(" ", numbers.TakeWhile(n => n < 4)));


            var objects = new List<object>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // IEnumerable<int> castQuery = numbers.Cast<double>(); conversion error
            IEnumerable<int> castQuery = objects.Cast<int>().ToList();
            Console.WriteLine($"object type before cast {objects.GetType()} aftere cast {castQuery.GetType()}");
            Console.WriteLine("\nCast:");
            Console.WriteLine(string.Join(" ", castQuery));

            Console.WriteLine("\nWhere:");
            Console.WriteLine(string.Join(" ", numbers.Where(n => n <= 5)));
            Console.WriteLine("\nWhere with index:");
            Console.WriteLine(string.Join(" ", numbers.Where((n, index) => n <= 5 || index > 8)));
            var numbersDuplicated = new List<int>() { 1, 7, 0, 1, 2, 3, 4, 5, 5, 6, 7, 8, 9, 8, 2, 7 };
            Console.WriteLine("\nDistinct");
            Console.WriteLine(string.Join(" ", numbersDuplicated.Distinct()));
            var objectsDifferentTypes = new List<object>() { 0, "1", 2, 3.0, 4, "5", 6, 7, 8, 9 };
            Console.WriteLine("\nOfType");
            Console.WriteLine(string.Join(" ", objectsDifferentTypes.OfType<int>()));
            Console.WriteLine("\nSingle");
            int queryValue = numbersDuplicated.Single(n => n == 3);
            //Console.WriteLine(numbers.Single(n => n < 0)); exception InvalidOperationException no number below zero
            Console.WriteLine(queryValue);
            Console.WriteLine("\nSingleOrDefault");
            int queryValueDefault = numbersDuplicated.SingleOrDefault(n => n < 0);
            Console.WriteLine(queryValueDefault);
            Console.WriteLine("\nFirst");
            int queryValueFirst = numbersDuplicated.First(n => n < 6);
            int elementFirst = numbersDuplicated.First();

            Console.WriteLine(queryValueFirst + " " + elementFirst);
            Console.WriteLine("\nLast");
            int queryValueLast = numbersDuplicated.Last(n => n < 6);
            int elementLast = numbersDuplicated.Last();
            Console.WriteLine(queryValueLast+ " " + elementLast);

            Console.WriteLine("OrderBy :");
            Console.WriteLine(string.Join(" ", numbers.OrderBy(n=>n)));

            Console.WriteLine("Reverse :");
            Console.WriteLine(string.Join(" ", numbers.Reverse()));

            Console.ReadLine();
        }

        private static IEnumerable<int> GetValues(int num)
        {
            for (int i = 0; i < num; i++)
            {
                yield return i;
            }
        }
    }

}
