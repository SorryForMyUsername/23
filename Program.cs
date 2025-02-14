using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calc1 = new Calculate();
            calc1.Output();
            Console.WriteLine(calc1);
            calc1.Field_1 = 3;
            calc1.Field_2 = 10;
            calc1.Output();
            Console.WriteLine();

            Calculate calc2 = new Calculate(4);
            calc2.Output();
            Console.WriteLine();

            Calculate calc3 = new Calculate(2, 3);
            calc3.Output();
            Console.WriteLine($"Результат обработки: {calc3.Handle():f2}\n");

            Console.Write("Поле 1: ");
            double field_1 = double.Parse(Console.ReadLine());
            Console.Write("Поле 2: ");
            double field_2 = double.Parse(Console.ReadLine());
            Calculate calc4 = new Calculate(field_1, field_2);
            calc4.Output();
            Console.WriteLine($"Результат обработки: {calc4.Handle():f2}");

            Console.ReadKey(true);
        }
    }
}
