using System;
namespace ConsoleApp
{
    class GradeAverage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Enter 5 grades separated by new line: ");
            int g1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n ");
            int g2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n ");
            int g3= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n ");
            int g4= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n ");
            int g5= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n ");
            double result = Convert.ToDouble(g1 + g2 + g3 +g4 +g5)/5;
            double ave = Math.Round(result, 0);
            Console.WriteLine("The average is " +result +" and round of to  " +ave);
            Console.WriteLine("\n Press any key to exit......");
            Console.ReadKey();
        }
    }
}