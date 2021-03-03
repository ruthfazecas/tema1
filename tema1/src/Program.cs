using System;
using tema1.src.model;

namespace tema1
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car("VW Golf 5", 2005, "Gas", "White");
            car.Colour = "Blue";
            Console.WriteLine(car);

            Street street = new Street("Decebal");
            Console.WriteLine(street);

            Building building = new Building("Tudor Vladimirescu 23", 1950, "Public");
            Console.WriteLine(building);



        }
    }
}
