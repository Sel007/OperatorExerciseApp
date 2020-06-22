using System;
using System.Net.NetworkInformation;

namespace OperatorExerciseConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //explicit typing
            string variableName = "Hello";

            //inferred typing
            var varName = "Hello";

            var a = 17;
            var b = 4;

            var div = a / b;
            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");

            var r = 20;

            Console.WriteLine($"What is the radius of your circle?");
            Console.ReadLine();

            var pi = Math.PI;

            var areaOfCircle = pi * (r * r);

            Console.WriteLine($"The area of circle with radius of {r} is {areaOfCircle}");

            Console.WriteLine("Please enter a number");

            var num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter another number");

            var num2 = double.Parse(Console.ReadLine());

            var result = Sum(num1, num2);

            Console.WriteLine(result);

            var result2 = Minus(num1, num2);

            Console.WriteLine(result2);

            var result3 = Multiply(num1, num2);

            Console.WriteLine(result3);

            var result4 = Divide(num1, num2);

            Console.Write(result4);

        }

        public static double Sum(double number1, double number2)
        {
            return number1 + number2;
        }

        public static double Minus(double number1, double number2)
        {
            return number1 - number2;
        }

        public static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        public static double Divide(double number1, double number2)
        {
            return number1 / number2;
        }

    }
}
