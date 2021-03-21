namespace BuilderPattern
{
    public interface IBuilder
    {
        void Reset();
        void SetSeats(int count);
        void SetEngine(string hp);
        void SetTripComputer(bool value);
        void SetGPS(bool value);
    }
}