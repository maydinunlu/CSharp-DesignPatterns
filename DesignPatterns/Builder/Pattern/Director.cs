namespace BuilderPattern
{
    public class Director
    {
        private IBuilder _builder;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void BuildSportCar()
        {
            _builder.Reset();
            _builder.SetSeats(2);
            _builder.SetEngine("120");
            _builder.SetTripComputer(true);
            _builder.SetGPS(false);
        }
        
        public void BuildSUV()
        {
            _builder.Reset();
            _builder.SetSeats(4);
            _builder.SetEngine("110");
            _builder.SetTripComputer(true);
            _builder.SetGPS(true);
        }
    }
}