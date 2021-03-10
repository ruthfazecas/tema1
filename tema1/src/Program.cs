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

            Building building = new Building
            {
                Address = "Tudor Vladimirescu 23",
                Category = BuildingCategory.Public,
                ConstructionYear = 1950

            };
            Console.WriteLine(building);



        }
    }
}
