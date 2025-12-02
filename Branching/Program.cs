using System;

class Program
{
    static void Main()
    {
        // Display a welcome message to the user
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt the user for the package weight
        Console.WriteLine("Please enter the package weight:");
        double weight = double.Parse(Console.ReadLine());

        // Check if the weight exceeds the limit of 50
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Exit the program if the package is too heavy
        }

        // Prompt the user for the package width
        Console.WriteLine("Please enter the package width:");
        double width = double.Parse(Console.ReadLine());

        // Prompt the user for the package height
        Console.WriteLine("Please enter the package height:");
        double height = double.Parse(Console.ReadLine());

        // Prompt the user for the package length
        Console.WriteLine("Please enter the package length:");
        double length = double.Parse(Console.ReadLine());

        // Check if the total of the dimensions (width + height + length) exceeds the limit of 50
        if (width + height + length > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Exit the program if the dimensions are too big
        }

        // Calculate the shipping quote: multiply the dimensions and weight, then divide by 100
        double quote = (width * height * length * weight) / 100;

        // Display the shipping quote to the user
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");

        // Thank the user for using the service
        Console.WriteLine("Thank you, Goodbye!");
    }
}
