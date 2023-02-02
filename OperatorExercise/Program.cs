using System.Diagnostics.CodeAnalysis;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
           
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);

            int qoutient = a / b;
            int remainder = a % b;
            if (a == 17 && b == 4);
            Console.WriteLine($"{a}/{b} is {qoutient} remainder {remainder}.");
            Console.WriteLine("what is the radius of yor circle?");
            var radius = double.Parse(Console.ReadLine());
            var answer = AreaOfCirle(radius);
            Console.WriteLine($" the circle with radius {radius} is {answer}");
        }
        public static double AreaOfCirle(double radius) 
        {
            return (Math.PI * radius * radius);
        }
    }

}
