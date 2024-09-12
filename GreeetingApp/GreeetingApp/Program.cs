using System;
// KAISSER CHRISTOPHER O. DIAZ BSIT 402
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        String name = Console.ReadLine();
        Console.Write("Enter total number of your enrolled courses: "); int course;
        course = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the price of your book: ");
        int price;
        price = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Total enrolled courses: " + course);
        Console.WriteLine("Price of my favorite book: " + price);
        Console.Write("\nPress any key to exit...");
        Console.ReadKey();
    }
}
