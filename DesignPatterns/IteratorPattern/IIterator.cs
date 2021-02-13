namespace IteratorPattern
{
    public interface IIterator
    {
        string Current // Can be generic
        {
            get;
        }
        bool HasNext();
        void Next();
    }
}