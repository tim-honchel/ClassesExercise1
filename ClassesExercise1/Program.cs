using System;

namespace ClassesExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("Honda", "Insight", 2021);
            Console.WriteLine(car1.Make + " " + car1.Model + " " + Convert.ToString(car1.Year));
        }
    }
}
