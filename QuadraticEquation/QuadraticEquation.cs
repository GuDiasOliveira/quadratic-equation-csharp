using System;
using System.Numerics;

namespace QuadraticEquation
{
    public class QuadraticEquation
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public QuadraticEquation()
        {
        }

        public QuadraticEquation(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double Delta
        {
            get
            {
                return B * B - 4 * A * C;
            }
        }

        public Complex[] SolveComplex()
        {
            double delta = Delta;

            if (A == 0)
            {
                if (B != 0)
                    return new Complex[] {-C / B };
                else
                    return new Complex[] { };
            }
            else if (delta > 0)
            {
                double x1 = (-B + Math.Sqrt(delta)) / (2 * A);
                double x2 = (-B - Math.Sqrt(delta)) / (2 * A);
                return new Complex[] { x1, x2 };
            }
            else if (delta == 0)
            {
                return new Complex[] { -B / (2 * A) };
            }
            else
            {
                double real = -B / (2 * A);
                double imaginary = Math.Sqrt(-delta) / (2 * A);
                return new Complex[]
                {
                    new Complex(real, imaginary),
                    new Complex(real, -imaginary)
                };
            }
        }

        public double[] SolveReal()
        {
            double delta = Delta;
            if (A == 0)
            {
                if (B != 0)
                    return new double[] { -C / B };
                else
                    return new double[] { };
            }
            else if (delta > 0)
            {
                double x1 = (-B + Math.Sqrt(delta)) / (2 * A);
                double x2 = (-B - Math.Sqrt(delta)) / (2 * A);
                return new double[] { x1, x2 };
            }
            else if (delta == 0)
            {
                return new double[] { -B / (2 * A) };
            }
            else
                return new double[] { };
        }
    }
}
