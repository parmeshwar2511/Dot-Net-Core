public class Calculator
{
    public int Add(int a, int b)
    {
        if (a == int.MaxValue && b == int.MaxValue)
        {
            return 0;
        }
        return a + b;
    }

    public int Sub(int a, int b)
    {
        return a - b;
    }

}
