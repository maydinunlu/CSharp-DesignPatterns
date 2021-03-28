using System;

namespace DesignPatterns.Builder
{
    public class CarBuilder : IBuilder
    {
        private Car _product;
        
        public CarBuilder()
        {
            Reset();
        }

        public Car GetProduct()
        {
            Reset();
            return _product;
        }
        
        public void Reset()
        {
            _product = new Car();
        }

        public void SetSeats(int count)
        {
            Console.WriteLine($"Seat count: {count}");   
        }

        public void SetEngine(string hp)
        {
            Console.WriteLine($"Install a given engine: {hp}");
        }

        public void SetTripComputer(bool value)
        {
            Console.WriteLine($"Install a trip computer: {value}");
        }

        public void SetGPS(bool value)
        {
            Console.WriteLine($"Install GPS: {value}");
        }
    }
}