using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Класс, описывающий вычисления
    /// </summary>
    internal class Calculate
    {
        /// <summary>
        /// Поле 1
        /// </summary>
        private double field_1;

        /// <summary>
        /// Поле 2
        /// </summary>
        private double field_2;
        public double Field_1 { get => field_1; 
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Значение меньше нуля!");
                }
                field_1 = value;
            } 
        }
        public double Field_2 { get => field_2;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Значение меньше нуля!");
                }
                field_2 = value;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Calculate() { }
        
        /// <summary>
        /// Конструктор с одним параметром.
        /// </summary>
        /// <param name="field_1">Поле 1</param>
        public Calculate(double field_1) 
        {  
            this.Field_1 = field_1; 
        } 

        /// <summary>
        /// Конструктор с двумя параметрами.
        /// </summary>
        /// <param name="field_1">Поле 1</param>
        /// <param name="field_2">Поле 2</param>
        public Calculate(double field_1, double field_2) : this(field_1)
        {
            this.Field_2 = field_2;
        }

        /// <summary>
        /// функция формирования строки с информацией об объекте.
        /// </summary>
        /// <returns>информацию об объекте в виде строки.</returns>
        public override string ToString()
        {
            return $"Поле 1: {Field_1}\tПоле 2: {Field_2}";
        }

        /// <summary>
        /// Функция формирования строки с информацией об объекте.
        /// </summary>
        public void Output()
        {
            Console.WriteLine($"Поле 1: {Field_1}\tПоле 2: {Field_2}");
        }

        /// <summary>
        /// функция обработки значений полей.
        /// </summary>
        /// <returns>Корень квадратный из произведения чисел.</returns>
        public double Handle()
        {
            return Math.Sqrt(Field_1 * Field_2);
        }
    }
}
