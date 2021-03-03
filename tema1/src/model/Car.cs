using System;
using System.Collections.Generic;
using System.Text;

namespace tema1.src.model
{
    class Car
    {
        private string model;
        private int year;
        private string fuelType;
        private string colour;


        public Car(string model, int year, string fuelType, string colour)
        {
            this.Model = model;
            this.Year = year;
            this.FuelType = fuelType;
            this.Colour = colour;
        }

        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public string FuelType { get => fuelType; set => fuelType = value; }
        public string Colour { get => colour; set => colour = value; }


        public override string ToString()
        {
            return model + " " + year + " " + fuelType + " " + colour;
        }
    }
}
