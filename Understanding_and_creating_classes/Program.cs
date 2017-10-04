using System;

namespace Understanding_and_creating_classes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // "new" creates a new instance of a class
            // a CLASS is the blueprint... an OBJECT is made from the blueprint 
            Car myNewCar = new Car();

            // SETTING the properties
            myNewCar.Make = "Oldsmobile";
            myNewCar.Model = "Cutlas Supreme";
            myNewCar.Year = 1986;
            myNewCar.Color = "Silver";

            // GETTING the properties 
            Console.WriteLine("{0} - {1} - {2}",
                             myNewCar.Make,
                              myNewCar.Model,
                              myNewCar.Color);

            //double marketValueOfCar = determineMarketValue(myNewCar);

            Console.WriteLine("Car's value: {0:C}", myNewCar.DetermineMarketValue());

            Console.Read();
        }


        private static double determineMarketValue(Car car)
        {
            double carValue = 100.0;

            // Someday write code to go online and look up the car's value and retreive its
            // value into the carValue variable 
            return carValue;
        }

    }

    class Car
    {
        // a property defines an attribute of a class 
        // a method defines a main body of code... something the class can DO 
        // "prop (tab) (tab)" 
        public string Make {get; set;}
        public string Model {get; set;}
        public int Year {get; set;}
        public string Color {get; set;}

        public double DetermineMarketValue()
        {
			double carValue = 100.0;

            // "this" allows you to access all the private and public members for 
            // an instance of a class
            if (this.Year > 1990)
                carValue = 10000.0;
            else
                carValue = 2000.0;

			return carValue;
        }

    }


}
