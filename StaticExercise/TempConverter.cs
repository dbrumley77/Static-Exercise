using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    static class TempConverter
    {
       




        public static double FahrenheitToCelsius(double fTemp)
        {
            double celsius = (fTemp - 32) * 5 / 9;
            return celsius;
        }

        public static double CelsiusToFahrenheit(double cTemp)
        {
            double fahrenheit = (cTemp * 9) / 5 + 32;
            return fahrenheit;
        }


    }



}
