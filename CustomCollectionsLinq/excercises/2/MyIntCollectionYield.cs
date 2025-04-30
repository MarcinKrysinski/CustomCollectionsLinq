using System.Collections;

namespace CustomCollectionsLinq.excercises._2;

public class MyIntCollectionYield : IEnumerable<int>
{
    private int[] numbers;

    public MyIntCollectionYield(int[] numbers)
    {
        this.numbers = numbers;
    }

    public IEnumerator<int> GetEnumerator()
    {
        // Dzięki yield return nie potrzebujemy ręcznie pisać klasy enumeratora
        foreach (var num in numbers)
        {
            yield return num;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}