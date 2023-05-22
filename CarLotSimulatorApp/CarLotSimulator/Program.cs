using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var lot = new CarLot();


            var Mustang = new Car();
            Mustang.Make = "Ford";
            Mustang.Model = "Mustang";
            Mustang.Year = 1969;
            Mustang.EngineNoise = "Amazing";
            Mustang.HonkNoise = "Wimpy";
            Mustang.IsDrivable = true;

            lot.Cars.Add(Mustang);

            var Ram = new Car("Dodge", "Ram", 2023, "intimidating", "better", true);
            lot.Cars.Add(Ram);

            var Xterra = new Car()
            {
                Make = "Nissan",
                Model = "Xterra",
                Year = 2018,
                EngineNoise = "Meh",
                HonkNoise = "Simple",
                IsDrivable = true,
            };
            lot.Cars.Add(Xterra);



            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");   
                car.MakeEngineNoise(car.EngineNoise);
                car.MakeHonkNoise(car.HonkNoise);
            }
        }

    }
    


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


