using System;

namespace BuilderPattern
{
    public class ManualBuilder : IBuilder
    {
        private Manual _product;
        
        public ManualBuilder()
        {
            Reset();
        }

        public Manual GetProduct()
        {
            Reset();
            return _product;
        }
        
        public void Reset()
        {
            _product = new Manual();
        }

        public void SetSeats(int count)
        {
            Console.WriteLine($"Document car seat features {count}");   
        }

        public void SetEngine(string hp)
        {
            Console.WriteLine($"Add engine instructions: {hp}");
        }

        public void SetTripComputer(bool value)
        {
            Console.WriteLine($"Add trip computer instructions: {value}");
        }

        public void SetGPS(bool value)
        {
            Console.WriteLine($"Add GPS instructions: {value}");
        }
    }
}