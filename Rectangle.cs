using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_2
{
    internal class Rectangle
    {
        /// <summary>
        /// Ширина
        /// </summary>
        private int width;
        /// <summary>
        /// Длина
        /// </summary>
        private int length;

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Rectangle() { }
        /// <summary>
        /// Конструктор с одним параметром
        /// </summary>
        /// <param name="width">Ширина</param>
        public Rectangle(int width) { 
            this.Width = width;
        }
        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="width">Ширина</param>
        /// <param name="length">Длина</param>
        public Rectangle(int width, int length) : this(width)
        {
            this.Length = length; 
        }

        /// <summary>
        /// Длина
        /// </summary>
        public int Length { get => length; 
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Значение меньше нуля!");
                }
                this.length = value;
            }
        }
        /// <summary>
        /// Ширина
        /// </summary>
        public int Width { get => width;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Значение меньше нуля!");
                }
                this.width = value;
            }
        }

        /// <summary>
        /// Метод, выводящий информацию об объекте.
        /// </summary>
        /// <returns>Информацию об объекте в виде строки</returns>
        public override string ToString()
        {
            return $"Ширина: {Width}\tДлина: {Length}";
        }

        /// <summary>
        /// Метод, вычисляющий периметр
        /// </summary>
        /// <returns>Периметр прямоугольника</returns>
        public int Perimeter()
        {
            return (Width + Length) * 2;
        }

        /// <summary>
        /// Метод, вычисляющий площадь
        /// </summary>
        /// <returns>Площадь прямоугольника</returns>
        public int Square()
        {
            return Width * Length;
        }
    }
}
