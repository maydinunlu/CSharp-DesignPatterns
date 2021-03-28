using System;

namespace DesignPatterns.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            testDevice(new TV());
            testDevice(new Radio());
        }
        
        public static void testDevice(IDevice device)
        {
            Console.WriteLine("Tests with basic remote.");
            BasicRemote basicRemote = new BasicRemote(device);
            basicRemote.Power();
            device.PrintStatus();

            Console.WriteLine("Tests with advanced remote.");
            AdvancedRemote advancedRemote = new AdvancedRemote(device);
            advancedRemote.Power();
            advancedRemote.Mute();
            device.PrintStatus();
        }
    }
}