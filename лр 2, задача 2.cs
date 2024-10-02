using System;
class Program
{
    static void Main()
    {
        int counterNechet = 0;
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (Math.Abs(a) % 2 != 0)
            {
                counterNechet++;
            }
        }
        if (counterNechet == n)
        {
            Console.WriteLine("Все элементы нечетные");
        }
        else
        {
            Console.WriteLine("НЕ все элементы нечетные");
        }
    }
}