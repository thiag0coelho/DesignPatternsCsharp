using System;
using System.Numerics;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new OrdinaryDiscriminantStrategy();
            var test2 = new QuadraticEquationSolver(test);
            test2.Solve(3, 2, -3);
            Console.WriteLine("Hello World!");
        }
    }

    public interface IDiscriminantStrategy
    {
        double CalculateDiscriminant(double a, double b, double c);
    }

    public class OrdinaryDiscriminantStrategy : IDiscriminantStrategy
    {
        public double CalculateDiscriminant(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }
    }

    public class RealDiscriminantStrategy : IDiscriminantStrategy
    {
        public double CalculateDiscriminant(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;

            return discriminant >= 0 ? discriminant : double.NaN;
        }
    }

    public class QuadraticEquationSolver
    {
        private readonly IDiscriminantStrategy strategy;

        public QuadraticEquationSolver(IDiscriminantStrategy strategy)
        {
            this.strategy = strategy;
        }

        public Tuple<Complex, Complex> Solve(double a, double b, double c)
        {
            var discriminant = new Complex(strategy.CalculateDiscriminant(a, b, c), 0);
            var rootDisc = Complex.Sqrt(discriminant);

            var plus = (-b + rootDisc) / 2 * a;

            var minus = (-b - rootDisc) / 2 * a;

            return new Tuple<Complex, Complex>(plus, minus);
        }
    }
}
