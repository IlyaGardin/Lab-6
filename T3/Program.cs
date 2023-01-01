

int[] numbers = { 1, 2, 3, 4, 5 };
int sum = numbers.Sum();
Console.WriteLine("Sum: " + sum);

public static class ArrayExtension 
{
    public static int Sum(this int[] arr)
    {
        int sum = 0;
        foreach (int i in arr)
        {
            sum += i;
        }
        return sum;
    }
}