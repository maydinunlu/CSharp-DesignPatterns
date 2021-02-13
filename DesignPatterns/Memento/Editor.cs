namespace Memento
{
    public class Editor
    {
        private string _content;
        public string Content
        {
            get => _content;
            set => _content = value;
        }

        public EditorState CreateState()
        {
            return new EditorState(_content);
        }

        public void Restore(EditorState state)
        {
            _content = state.Content;
        }
    }
}