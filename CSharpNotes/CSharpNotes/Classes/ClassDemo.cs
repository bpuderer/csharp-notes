using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNotes.Classes
{
    public static class ClassDemo
    {
        public static void Demo()
        {
            Car myCar = new Car();
            myCar.Make = "Honda";
            myCar.Model = "Accord";
            myCar.Year = 2012;
            myCar.Color = "Grey";
            myCar.Type = Car.CarType.Coupe;

            Car myCar2 = new Car("Honda", "Civic", 2002, "Silver", Car.CarType.Sedan);

            Car myCar3 = new Car();

            myCar.PrintCar();
            myCar2.PrintCar();
            myCar3.PrintCar();

            
        }
    }
}
