using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car() 
        { 
        }
        public Car(string make, string model, int year, string engineNoise, string honkNoise, bool isDrvable) 
        { 
            Make = make;
            Model = model;
            Year = year;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDrvable;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

        public void MakeEngineNoise(string enginenoise) 
        {
            Console.WriteLine($"{enginenoise}");
        }
        public void MakeHonkNoise(string honknoise) 
        { 
            Console.WriteLine ($"{honknoise}");
        }
    }
}
