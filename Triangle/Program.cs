using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, S;

            try
            {
                Console.WriteLine("Введите сторону A: ");
                A = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите сторону B: ");
                B = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите сторону C: ");
                C = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Вводите только числа!");
                Console.ReadLine();
                return;
            }
            catch
            {
                throw;
            }

            Square square = new Square();
            new NotTriangle(square);
            S = square.SquareCalculate(A, B, C);
            Console.WriteLine("Площадь треугольника: " + S);

            Console.ReadLine();
        }
    }

    //паттерн observer
    class NotTriangle
    {
        public NotTriangle(Square square)
        {
            square.Message += StopCalculate;
        }
        void StopCalculate()
        {
            Console.WriteLine("Не треугольник!");
        }
    }
}
