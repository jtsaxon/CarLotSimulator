using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new CarLot();
           
            //Using dot notation.
            var jakesCar = new Car();
            jakesCar.Make = "Jeep";
            jakesCar.Model = "Cherokee";
            jakesCar.Year = 2016;
            jakesCar.EngineNoise = "Vroom";
            jakesCar.HonkNoise = "Boop boop";
            jakesCar.IsDrivable = true;

            //Object Initializer Syntax
            var lukesCar = new Car()
            {
                Make = "Ford",
                Model = "F150",
                Year = 2008,
                EngineNoise = "Sputter",
                HonkNoise = "Honk honk",
                IsDrivable = false
            };

            //Using the constructor to allow parameter values to be placed inside properties.
            var johnsCar = new Car(2013, "Honda", "Civic", "Zoom", "Beep beep", true);

            lukesCar.MakeHonkNoise();
            lukesCar.MakeEngineNoise();

            johnsCar.MakeHonkNoise();
            johnsCar.MakeEngineNoise();

            jakesCar.MakeHonkNoise();
            jakesCar.MakeEngineNoise();

            jakesCar.CarDetails();

            carLot.LotList.Add(jakesCar);
            carLot.LotList.Add(johnsCar);
            carLot.LotList.Add(lukesCar);

            foreach (var car in carLot.LotList)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }

            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property            


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
