using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNotes.Classes
{
    class Car
    {
        public enum CarType { Sedan, Hatchback, Coupe }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public CarType Type { get; set; }

        public Car()
        {
            // this. not necessary
            Make = "McLaren";
        }

        public Car(string make, string model, int year, string color, CarType type)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            Type = type;
        }

        public void PrintCar()
        {
            Console.WriteLine(String.Format("{0:C} {1} {2} {3} {4} {5}", DetermineMarketValue(), Year, Make, Model, Color, Type));
        }

        public decimal DetermineMarketValue()
        {
            if (Year > 2010)
                return 10000;
            else
                return 1000;
        }
    }
}
