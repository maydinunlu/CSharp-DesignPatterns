namespace DesignPatterns.Bridge
{
    public interface IDevice
    {
        bool IsEnabled();

        void Enable();
        void Disable();

        int Volume { get; set; }
        int Channel { get; set; }
        
        void PrintStatus();
    }
}