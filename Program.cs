using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ширина: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Длина: ");
            int height = int.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(width, height);
            Console.WriteLine(rectangle);

            Console.WriteLine($"Периметр: {rectangle.Perimeter()}");
            Console.WriteLine($"Площадь: {rectangle.Square()}");

            Console.ReadKey(true);
        }
    }
}
