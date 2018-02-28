using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsPlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> values = new List<string>() { "ala ma", "malego", "kota" };
            using (var enumerator = values.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current);
                }
            }

            do
            {
                Console.WriteLine("Game Play ;)");
                Console.WriteLine("Want to play Again? Yes / No");
            } while (!Console.ReadLine().StartsWith("N", StringComparison.InvariantCultureIgnoreCase));



            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine(i);
            }

            List<int> intValues = new List<int>() { 2, 5, 7, 9, 3, 10, 34 };
            intValues.ForEach(element => Console.WriteLine(element));
            foreach (int element in intValues)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("skip odd elements");
            foreach (int element in intValues)
            {
                if (element % 2 == 1)
                {
                    continue;
                }

                Console.WriteLine(element);
            }

            Console.WriteLine("stop processing after negetive element difference");
            for (int i = 0, j = intValues[0]; i < intValues.Count; i++)
            {
                if (j > intValues[i])
                {
                    break;
                }
                j = intValues[i];
                Console.WriteLine(intValues[i]);
            }

            for (int i = 0; Condition(i); Increment(ref i))
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
        public static void Increment(ref int variable)
        {
            Console.WriteLine("increment");
            variable += 1;
        }
        public static bool Condition(int i)
        {
            Console.WriteLine("Condition");
            return i < 10;
        }
    }
}
