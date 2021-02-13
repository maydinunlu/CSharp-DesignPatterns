# CSharp-DesignPatterns

* Patterns
  * [Memento](#Memento) 
  * [State](#State) 

## Memento

![](DesignPatterns/MementoPattern/Assets/Memento.png)

C# Code

```c#

public class EditorState
{
    private readonly string _content;
    public string Content => _content;

    public EditorState(string content)
    {
        _content = content;
    }
}

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


class Program
{
    static void Main(string[] args)
    {
        Editor editor = new Editor();
        History history = new History();

        editor.Content = "Content-1";
        history.Push(editor.CreateState());
        Console.WriteLine("Current: " + editor.Content);

        editor.Content = "Content-2";
        history.Push(editor.CreateState());
        Console.WriteLine("Current: " + editor.Content);

        Console.WriteLine("------------------");

        editor.Content = "Content-3";
        editor.Restore(history.Pop());
        editor.Restore(history.Pop());
        Console.WriteLine("Current: " + editor.Content);
    }
}

```

Console Output

```console
Current: Content-1
Current: Content-2
------------------
Current: Content-1
```

***

## State

![](DesignPatterns/StatePattern/Assets/State.png)

C# Code

```c#

public interface IControl
{
    void Render();
}
 
public class TextControl : IControl
{
    public void Render()
    {
        Console.WriteLine("Render: Text");
    }
}

public class ButtonControl : IControl
{
    public void Render()
    {
        Console.WriteLine("Render: Button");
    }
}

public class Canvas
{
    private IControl _currentControl;
    public IControl CurrentControl
    {
        get => _currentControl;
        set => _currentControl = value;
    }

    public void Render()
    {
        _currentControl.Render();
    }
}


class Program
{
    static void Main(string[] args)
    {
        Canvas canvas = new Canvas();

        canvas.CurrentControl = new ButtonControl();
        canvas.Render();

        canvas.CurrentControl = new TextControl();
        canvas.Render();
    }
}
```

Console Output

```console
Render: Button
Render: Text
```
