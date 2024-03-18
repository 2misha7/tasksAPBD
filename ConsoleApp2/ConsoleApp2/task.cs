namespace ConsoleApp2;

public class task
{
    public static double CalcAverage(int[] numbers)
    {   var thisSum = 0;
        foreach (int num in numbers)
        {
            thisSum += num;
        }
        return (double)thisSum / numbers.Length;
    }
    
    public static int FindMax(int[] numbers)
    {
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }
}
