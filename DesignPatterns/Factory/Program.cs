namespace DesignPatterns.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            client.Init();
            client.ShowForm();
        }
    }
}