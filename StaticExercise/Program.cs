using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to go from:" +
                "\nFahrenheit to celsius (press 1)" +
                "\nor Celsius to fahrenheit");
            int response = int.Parse(Console.ReadLine());
            Console.WriteLine("\nPick a number!\n");

            if (response == 1)
            {
                Console.WriteLine(TempConverter.FahrenheitToCelsius(double.Parse(Console.ReadLine())));
            }
            else
            {
                Console.WriteLine(TempConverter.CelsiusToFahrenheit(double.Parse(Console.ReadLine())));
            }
        }
    }
}
