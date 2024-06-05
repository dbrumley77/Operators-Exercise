using System.Diagnostics.CodeAnalysis;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius");
            string userInput = Console.ReadLine();
            double parsedUserInput = double.Parse(userInput);
            double answer = AreaofCircle(parsedUserInput);
            Console.WriteLine(answer);

           


            int a = 17;
            int b = 4;

            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            Console.WriteLine($"{a}-{b} is {difference}");
            Console.WriteLine($"{a}+{b} is {sum}");
            Console.WriteLine($"{a}*{b} is {product}");


        }

        public static double AreaofCircle(double radius)
        {
            double area = Math.PI* Math.Pow(radius, 2);
            return area;

        }
    }

}
