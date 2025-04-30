using System.Collections;

namespace CustomCollectionsLinq.excercises._1;

public class MyIntEnumerator: IEnumerator<int>
{
    private int[] _numbers;
    private int position = -1; // Zaczynamy przed pierwszym elementem

    public MyIntEnumerator(int[] numbers)
    {
        _numbers = numbers;
    }

    // Właściwość Current (generyczna)
    public int Current
    {
        get
        {
            if (position < 0 || position >= _numbers.Length)
                throw new InvalidOperationException();
            return _numbers[position];
        }
    }

    // Właściwość Current (niegeneryczna)
    object IEnumerator.Current => Current;

    // Przejście do kolejnego elementu
    public bool MoveNext()
    {
        position++;
        return position < _numbers.Length;
    }

    // Resetowanie enumeratora
    public void Reset()
    {
        position = -1;
    }
    
    // Zwalnianie zasobów (tu nieużywane)
    public void Dispose()
    {
        // Nic do zwolnienia w tym przykładzie
    }
}
