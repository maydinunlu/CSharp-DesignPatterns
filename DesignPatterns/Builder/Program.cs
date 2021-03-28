using System;

namespace DesignPatterns.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            CarBuilder carBuilder = new CarBuilder();

            Director director = new Director(carBuilder);

            Console.WriteLine("Create a Sport Car");
            director.BuildSportCar();
            Car sportCar = carBuilder.GetProduct();
            
            Console.WriteLine("Create a SUV");
            director.BuildSUV();
            Car suv = carBuilder.GetProduct();
        }
    }
}