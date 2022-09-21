using System;
namespace ConsoleApp
{
class SchoolForm
{
     static void Main(string[] args)
    {
        
       
        Console.Write ("\nEnter your name:");
        string name = Console.ReadLine();
        Console.Write ("\nEnter the total number of your enrolled courses: ");
        int  courses;
        courses = Convert.ToInt32(Console.ReadLine());
        Console.Write ("\nEnter the price of your favorite book: ");
        double book;
        book = Convert.ToDouble(Console.ReadLine());
        
  
        Console.WriteLine("\nName:" + name );
        Console.WriteLine("Total enrolled courses:" + courses );
        Console.WriteLine("Price of my favorite book:" + book );
 
    }
}
}