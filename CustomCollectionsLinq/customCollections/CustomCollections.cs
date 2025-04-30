using System.Collections;

namespace CustomCollectionsLinq;

public class CustomCollections<T> : IEnumerable<T>
{
    private List<T> _items = new List<T>();

    public void Add(T item)
    {
        _items.Add(item);
    }


    public IEnumerator<T> GetEnumerator()
    {
        return new CustomEnumerator<T>(_items);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}