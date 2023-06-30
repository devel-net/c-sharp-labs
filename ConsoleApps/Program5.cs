using System;

public static class MathUtils
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

class Program5
{
    static void Main()
    {
        int sum = MathUtils.Add(2, 3);
        Console.WriteLine(sum);  // 5

        Console.ReadLine();
    }
}