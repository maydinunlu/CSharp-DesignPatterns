namespace DesignPatterns.Bridge
{
    public interface IRemote
    {
        void Power();

        void VolumeDown();
        void VolumeUp();

        void ChannelDown();
        void ChannelUp();
    }
}