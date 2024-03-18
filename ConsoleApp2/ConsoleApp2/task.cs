namespace ConsoleApp2;

public class task
{
    public static double CalcAverage(int[] numbers)
    {   var sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return (double)sum / numbers.Length;
    }
}
