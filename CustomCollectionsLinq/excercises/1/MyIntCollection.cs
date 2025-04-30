using System.Collections;

namespace CustomCollectionsLinq.excercises._1;

public class MyIntCollection : IEnumerable<int>
{
    private int[] numbers;

    public MyIntCollection(int[] numbers)
    {
        this.numbers = numbers;
    }

    public IEnumerator<int> GetEnumerator()
    {
        return new MyIntEnumerator(numbers);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}