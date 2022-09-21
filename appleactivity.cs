using System;
namespace ConsoleApp
{
class Apple
{
     static void Main(string[] args)
    {
        
       
        Console.Write ("\nEnter the pieces of apple:");
        int apple = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the total price of " + apple + " apple:");
        double totalprice= Convert.ToDouble(Console.ReadLine());
        double output =Math.Round(totalprice, 1);
        double converted =Math.Floor(totalprice);
        Console.WriteLine("The total price of "+apple+ " is " +output);
        Console.WriteLine("The value of original price is "+ output);
        Console.WriteLine("The value of converted price is " + converted);
        Console.WriteLine("\n Press any key to exit......");
        Console.ReadKey();
        
        
       
 
    }
}
}