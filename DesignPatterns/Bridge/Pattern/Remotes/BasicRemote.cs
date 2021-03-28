using System;

namespace DesignPatterns.Bridge
{
    public class BasicRemote : IRemote
    {
        protected IDevice _device;

        public BasicRemote()
        {
            
        }

        public BasicRemote(IDevice device)
        {
            _device = device;
        }

        public void Power()
        {
            Console.WriteLine("Remote: power toggle");
            if (_device.IsEnabled()) 
            {
                _device.Disable();
            } 
            else 
            {
                _device.Enable();
            }
        }

        public void VolumeDown()
        {
            Console.WriteLine("Remote: volume down");
            _device.Volume -= 10;
        }

        public void VolumeUp()
        {
            Console.WriteLine("Remote: volume up");
            _device.Volume += 10;
        }

        public void ChannelDown()
        {
            Console.WriteLine("Remote: channel down");
            _device.Channel -= 1;
        }

        public void ChannelUp()
        {
            Console.WriteLine("Remote: channel up");
            _device.Channel += 1;
        }
    }
}