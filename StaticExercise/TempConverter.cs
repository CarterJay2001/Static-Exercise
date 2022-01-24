using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        static TempConverter()
        {
        }

        public static double FahrenheitToCelsius(double num)
        {
            int ans = (int)(num - 32);
            return ans * .5556;
        }

        public static double CelsiusToFahrenheit (double num)
        {
            int ans = (int)(num * 1.8);
            return ans + 32;
        }
    }
}
