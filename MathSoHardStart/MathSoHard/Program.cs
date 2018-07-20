using MathSoHardLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSoHard
{
    class Program
    {

        private static Derivative derivative;

        static void Main(string[] args)
        {
            derivative = new Derivative();
            Console.WriteLine(derivative.TakeDerivative("x^4 + 2x^3 + x^2 + 4x + 1"));
            Console.ReadLine();
        }
    }
}
