using System.Collections;

namespace CustomCollectionsLinq;

public class CustomEnumerator<T>: IEnumerator<T>
{
    private readonly List<T> _items;
    private int _index = -1;
    public T Current => _items[_index];

    public CustomEnumerator(List<T> items)
    {
        _items = items;
    }
    
    object IEnumerator.Current => Current;
    
    public bool MoveNext()
    {
        _index++;
        return _index < _items.Count;
    }

    public void Reset()
    {
        _index = -1;
    }

    public void Dispose()
    {
        //nic nie ma do zwolnienia, ale musimy zapimplentować
    }
}