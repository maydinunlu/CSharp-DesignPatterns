namespace MementoPattern
{
    public class EditorState
    {
        private readonly string _content;
        public string Content => _content;

        public EditorState(string content)
        {
            _content = content;
        }
    }
}