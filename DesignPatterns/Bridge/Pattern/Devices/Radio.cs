using System;

namespace DesignPatterns.Bridge
{
    public class Radio : IDevice
    {
        private bool _on = false;
        
        private int _volume = 30;
        public int Volume
        {
            get => _volume; 
            set
            {
                if (value > 100) 
                {
                    _volume = 100;
                } 
                else if (value < 0) 
                {
                    _volume = 0;
                }
                else 
                {
                    _volume = value;
                }
            }
        }
        
        private int _channel = 1;
        public int Channel 
        {
            get => _channel;
            set => _channel = value;
        }
        
        
        public bool IsEnabled()
        {
            return _on;
        }

        public void Enable()
        {
            _on = true;
        }

        public void Disable()
        {
            _on = false;
        }

        
        public void PrintStatus()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("| I'm radio.");
            Console.WriteLine("| I'm " + (_on ? "enabled" : "disabled"));
            Console.WriteLine("| Current volume is " + _volume + "%");
            Console.WriteLine("| Current channel is " + _channel);
            Console.WriteLine("------------------------------------\n");
        }
    }
}