using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть перше число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введіть друге число: ");
            int b = int.Parse(Console.ReadLine());

            int sum = a + b;

            Console.WriteLine("Сума: " + sum);

            Console.WriteLine("\nНатисніть будь-яку клавішу, щоб вийти...");
            Console.ReadKey();
        }
    }
}
