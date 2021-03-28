using System;

namespace DesignPatterns.Bridge
{
    public class AdvancedRemote : BasicRemote
    {
        public AdvancedRemote(IDevice device)
            :base(device)
        {
            
        }

        public void Mute()
        {
            Console.WriteLine("Remote: mute");
            _device.Volume = 0;
        }
    }
}