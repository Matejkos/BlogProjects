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
            var numbers = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
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
