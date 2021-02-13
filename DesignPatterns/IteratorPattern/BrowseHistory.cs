using System.Collections.Generic;

namespace IteratorPattern
{
    public class BrowseHistory
    {
        private readonly List<string> _urlList = new();

        public void Push(string url)
        {
            _urlList.Add(url);
        }

        public string Pop()
        {
            var index = _urlList.Count - 1;
            
            var url = _urlList[index];
            _urlList.RemoveAt(index);

            return url;
        }
        
        public IIterator CreateIterator()
        {
            return new ListIterator(this);
        }
        
        private class ListIterator : IIterator
        {
            private readonly BrowseHistory _browseHistory;
            private int _index;

            public string Current => _browseHistory._urlList[_index];

            public ListIterator(BrowseHistory browseHistory)
            {
                _browseHistory = browseHistory;
            }
        
            public bool HasNext()
            {
                return _index < _browseHistory._urlList.Count;
            }

            public void Next()
            {
                _index++;
            }
        }
    }
}