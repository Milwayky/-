using System;
class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int counterMax = 0;
        
        if (n < 3)
        {
            Console.WriteLine("0 локальных максимумов");
            return;
        }
        
        
        for (int i = 3; i <= n; i++)
        {
            int c = Convert.ToInt32(Console.ReadLine());
            if (b > a && b > c)
            {
                counterMax+=1;
            }
            a = b;
            b = c;
        }

        Console.WriteLine($"Количество локальных максимумов: {counterMax}");
    }
}
