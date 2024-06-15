using System.Security.Principal;

namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Call a static method
            //TempConverter.FahrenheitToCelsius(20.5);
            //ClassName.MethodName();

            //needed for print to console
            double answer1 = TempConverter.FahrenheitToCelsius(7.5);
            Console.WriteLine(Math.Round(answer1, 2));


            double answer2 = TempConverter.CelsiusToFahrenheit(-13.61111);
            Console.WriteLine($"-13.61111 degree celsius is {answer2} degress fahrenheit.");

           
            


        }




    }




}
