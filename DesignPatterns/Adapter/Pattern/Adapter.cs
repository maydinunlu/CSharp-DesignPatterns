namespace DesignPatterns.Adapter
{
    // The Adapter makes the Adaptee's interface compatible with the Target's
    // interface.
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }
        
        public string GetRequest()
        {
            return _adaptee.GetSpecificRequest();
        }
    }
}