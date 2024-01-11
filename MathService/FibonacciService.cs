namespace MathService;

public class FibonacciService
{
    public static int GetFibValueOf(int n)
    {
        if (n == 0 || n == 1)
        {
            return n;
        }
        return GetFibValueOf(n - 1) + GetFibValueOf(n - 2);
    }
}
