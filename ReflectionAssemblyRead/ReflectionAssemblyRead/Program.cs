using System;
using System.Reflection;

namespace ReflectionAssemblyRead
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.LoadFrom("ExternalLibrary.dll");
            foreach (var atribute in assembly.CustomAttributes)
            {
                Console.WriteLine($"{atribute.ToString()}");
            }
            Console.WriteLine();
            foreach (var type in assembly.ExportedTypes)
            {
                Console.WriteLine(type.ToString());
                Console.WriteLine("Constructors");
                foreach (var ctrs in type.GetConstructors())
                {
                    Console.WriteLine($"\t {ctrs.ToString()}");
                    foreach (var param in ctrs.GetParameters())
                    {
                        Console.WriteLine($"\t\t parmeter {param.Name} : {param.ParameterType}");
                    }
                }
                Console.WriteLine("Properties");
                foreach (var prop in type.GetProperties())
                {
                    Console.WriteLine($"\t {prop.ToString()}");
                }
                Console.WriteLine("Fields");
                foreach (var prop in type.GetFields())
                {
                    Console.WriteLine($"\t {prop.ToString()}");
                }

                Console.WriteLine("Methods");
                foreach (var method in type.GetMethods())
                {
                    Console.WriteLine($"\t {method.ToString()}");
                    foreach (var param in method.GetParameters())
                    {
                        Console.WriteLine($"\t\t parmeter {param.Name} : {param.ParameterType}");
                    }
                    Console.WriteLine($"\t\t return : {method.ReturnType}");
                }
            }
            Console.ReadLine();
        }
    }
}
