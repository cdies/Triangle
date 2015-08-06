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
                Console.WriteLine("input A: ");
                A = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("input B: ");
                B = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("input C: ");
                C = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: You input not number!");
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
            Console.WriteLine("Square " + S);

            Console.ReadLine();
        }
    }

    class NotTriangle
    {
        public NotTriangle(Square square)
        {
            square.Message += StopCalculate;
        }
        void StopCalculate()
        {
            Console.WriteLine("Not triangle!");
        }
    }
}
