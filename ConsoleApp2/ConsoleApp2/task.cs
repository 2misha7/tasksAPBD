namespace ConsoleApp2;

public class task
{
    public static double CalcAverage(int[] numbers)
    {   var mySum = 0;
        foreach (int num in numbers)
        {
            mySum += num;
        }
        return (double)mySum / numbers.Length;
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
