namespace DesignPatterns.Singleton
{
    public sealed class Singleton
    {
        private static readonly Singleton _instance = new Singleton();
        public static Singleton Instance => _instance;
        
        static Singleton()
        {
        }

        private Singleton()
        {
        }
    }
}