using System.Collections.Generic;

namespace MementoPattern
{
    public class History
    {
        private readonly List<EditorState> _states = new();

        public void Push(EditorState state)
        {
            _states.Add(state);
        }

        public EditorState Pop()
        {
            int index = _states.Count - 1;
            
            EditorState state = _states[index];
            _states.RemoveAt(index);

            return state;
        }
    }
}