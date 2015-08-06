using System;

namespace Triangle
{
    public class Square
    {
        public double P { get; private set; }
        public double S { get; private set; }
        public event Action Message;
        double A, B, C;

        public Square()
            : this(0, 0, 0)
        {
        }
        public Square(double A, double B, double C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public double SquareCalculate()
        {
            return SquareCalculate(A, B, C);
        }

        public double SquareCalculate(double A, double B, double C)
        {
            if (A + B < C || A + C < B || B + C < A || A == 0 || B == 0 || C == 0)
            {
                if (Message != null)
                    Message();

                return 0;
            }

            P = (A + B + C) / 2;
            S = Math.Sqrt(P * (P - A) * (P - B) * (P - C));

            return S;
        }

    }
}
