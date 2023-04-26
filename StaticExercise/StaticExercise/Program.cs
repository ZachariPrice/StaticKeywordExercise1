using System;

namespace StaticExercise
{

    class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelsius(75); // 23.88888888888889
            var fahrenheit = TempConverter.CelciusToFahrenheit(23.88888888888889);

            Console.WriteLine($"celcius {celcius}");

            Console.WriteLine($"fahrenheit {fahrenheit}");
        }
    }
}