using System;

namespace MyPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pythagorean Theorem Calculator");
            Console.WriteLine(" ");

            Console.WriteLine("Which side do you want to find? a = adjacent, b=opposite, c= hypotenuse");
            String side = Console.ReadLine();

            switch (side.ToLower())
            {
                case "a":
                    Console.WriteLine("Enter the hypotenuse:");
                    double c = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the opposite:");
                    double b = Convert.ToDouble(Console.ReadLine());

                    double a = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(b, 2));
                    Console.WriteLine("the adjacent is " + a);
                    break;

                case "b":
                    Console.WriteLine("Enter the hypotenuse:");
                     c = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the adjacent:");
                     a = Convert.ToDouble(Console.ReadLine());

                     b = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2));
                    Console.WriteLine("the opposite is " + b);
                    break;

                case "c":
                    Console.WriteLine("Enter the adjacent:");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the opposite:");
                    b = Convert.ToDouble(Console.ReadLine());

                    c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                    Console.WriteLine("The hypotenuse is " + c);
                    break;

                default:
                    Console.WriteLine("Pick between a,b and c");
                    break;
            }

            /*Console.WriteLine("Enter the hypotenus: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the adjacent: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the opposite: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if(c < 0 || a < 0 || b < 0)
            {
                Console.WriteLine("All the numbers must positive");
            }
            else if(c == 0)
            {
                c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                Console.WriteLine(c);
            }
            else if(a == 0)*/

            /*a = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(b, 2));
            b = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2));
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));*/

           
            
        }
    }
}
