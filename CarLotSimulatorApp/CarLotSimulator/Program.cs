using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var lot = new CarLot();
            

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var dreamCar = new Car();
            dreamCar.Make = "Audi";
            dreamCar.Model = "A8";
            dreamCar.Year = 2023;
            dreamCar.EngineNoise = "smooth";
            dreamCar.HonkNoise = "elegant";
            dreamCar.IsDrivable = true;

            lot.Cars.Add(dreamCar);

            var currentCar = new Car()
                {
                    Year = 2002,
                    Make = "Honda",
                    Model = "Civic",
                    EngineNoise = "crickety",
                    HonkNoise = "loud",
                    IsDrivable = true,
                };
            lot.Cars.Add(currentCar);


            var friendCar = new Car(2020, "Hyundai", "Genesis", "quiet", "beep", true);

            lot.Cars.Add(friendCar);


            dreamCar.MakeEngineNoise(dreamCar.EngineNoise);
            currentCar.MakeEngineNoise(currentCar.EngineNoise);
            friendCar.MakeEngineNoise(friendCar.EngineNoise);



            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");

            }
        }
    }
}
